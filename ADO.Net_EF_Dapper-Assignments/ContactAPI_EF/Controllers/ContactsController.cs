namespace ContactAPI_EF.Controllers
{
    using ContactAPI_EF.Data;
    using ContactAPI_EF.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Serilog;
    using Serilog.Core;

    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public ContactsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        private readonly ContactsAPIDbContext dbContext;
        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            _logger.LogInformation("Get Method");
            return Ok(await dbContext.Contacts.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContactById([FromRoute] Guid id)
        {
            _logger.LogInformation("Get contact by Id Method");
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            _logger.LogInformation(" Add Contact Method");
            var contact = new Contact()
            {
                Id=Guid.NewGuid(),
                Address=addContactRequest.Address,
                Email=addContactRequest.Email,
                FullName=addContactRequest.FullName,
                Phone=addContactRequest.Phone           
            };

           await dbContext.Contacts.AddAsync(contact);
           await dbContext.SaveChangesAsync();
           return Ok(contact);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<ActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {
            _logger.LogInformation("Update Method");
            var contact = dbContext.Contacts.Find(id);
            if (contact != null)
            {
                contact.FullName = updateContactRequest.FullName;
                contact.Address = updateContactRequest.Address;
                contact.Phone = updateContactRequest.Phone;
                contact.Email = updateContactRequest.Email;

                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            _logger.LogInformation("Delete Method");
            var contact = await dbContext.Contacts.FindAsync(id);
            if (contact != null)
            {
                dbContext.Contacts.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }
    }
}
