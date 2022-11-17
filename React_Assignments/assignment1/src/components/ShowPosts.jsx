import React from 'react'
//passing array as obj from app to page?

const posts = [
    {
        userId: 1,
        id: 1,
        title:
            'sunt aut facere repellat provident occaecati excepturi optioreprehenderit',
        body: 'quia et suscipit\nsuscipit recusandae consequuntur expedita etcum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autemsunt rem eveniet architecto',
    },
    {
        userId: 1,
        id: 2,
        title: 'qui est esse',
        body: 'est rerum tempore vitae\nsequi sint nihil reprehenderit dolorbeatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihilmolestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisinulla',
    },
    {
        userId: 1,
        id: 3,
        title: 'ea molestias quasi exercitationem repellat qui ipsa sit aut',
        body: 'et iusto sed quo iure\nvoluptatem occaecati omnis eligendi autad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porroeius odio et labore et velit aut',
    },
    {
        userId: 1,
        id: 4,
        title: 'eum et est occaecati',
        body: 'ullam et saepe reiciendis voluptatem adipisci\nsit amet autemassumenda provident rerum culpa\nquis hic commodi nesciunt rem teneturdoloremque ipsam iure\nquis sunt voluptatem rerum illo velit',
    },
    {
        userId: 1,
        id: 5,
        title: 'nesciunt quas odio',
        body: 'repudiandae veniam quaerat sunt sed\nalias aut fugiat sitautem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest auttenetur dolor neque',
    },
    {
        userId: 1,
        id: 6,
        title: 'dolorem eum magni eos aperiam quia',
        body: 'ut aspernatur corporis harum nihil quis providentsequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo abreprehenderit accusantium quas\nvoluptate dolores velit et doloremquemolestiae',
    },
    {
        userId: 1,
        id: 7,
        title: 'magnam facilis autem',
        body: 'dolore placeat quibusdam ea quo vitae\nmagni quis enim quiquis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequieos ea sed quas',
    },
    {
        userId: 1,
        id: 8,
        title: 'dolorem dolore est ipsam',
        body: 'dignissimos aperiam dolorem qui eum\nfacilis quibusdam animisint suscipit qui sint possimus cum\nquaerat magni maioresexcepturi\nipsam ut commodi dolor voluptatum modi aut vitae',
    },
    {
        userId: 1,
        id: 9,
        title: 'nesciunt iure omnis dolorem tempora et accusantium',
        body: 'consectetur animi nesciunt iure dolore\nenim quia ad\nveniamautem ut quam aut nobis\net est aut quod aut provident voluptas autemvoluptas',
    },
]

//Created Functional component to render data in table format
function ShowPostsInTable() {
    return (
        <div >
            <table class="table table-striped table-hover">
                <thead>
                    <th>USER ID</th>
                    <th>ID</th>
                    <th>TITLE</th>
                    <th>BODY</th>
                </thead>
                <tbody>
                    {/* Accessing elements by using map method */}
                    {posts.map((values) => {
                        return (
                            <tr>
                                <td>{values.userId}</td>
                                <td>{values.id}</td>
                                <td>{values.title}</td>
                                <td>{values.body}</td>
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    )
}

//Created Functional component to render data in list format
const ShowPostsInList = () => {
    return (
        <div>
            {posts.map((value) => {
                return (
                    <div>
                        <ul><li class="list-group-item list-group-item-info">USER ID: {value.userId}</li><ul>
                            <li class="list-group-item list-group-item-secondary">ID: {value.id}</li>
                            <li class="list-group-item list-group-item-secondary">TITLE: {value.title}</li>
                            <li class="list-group-item list-group-item-secondary">BODY: {value.body}</li>
                        </ul>
                        </ul>
                    </div>
                )
            })}
        </div>
    )
}

const ShowPosts = () => {
    return (
        <div>
            <h3>Posts Table</h3>
            {/* calling ShowPostsInTable component to show posts in table format */}
            {ShowPostsInTable(posts)}
            <hr />
            <h3>Posts List</h3>
             {/* calling ShowPostsInList component to show posts in list format */}
            {ShowPostsInList(posts)}
        </div>
    )
}

export default ShowPosts