--use hr_db;

--select distinct (DEPARTMENT_ID) from employees;

--select * from employees order by FIRST_NAME desc;

--select EMPLOYEE_ID,FIRST_NAME,LAST_NAME,SALARY from employees order by SALARY asc;

--select e.FIRST_NAME,e.HIRE_DATE,e.JOB_ID,j.JOB_TITLE from employees e full outer join jobs j on e.JOB_ID=j.JOB_ID where e.JOB_ID='IT_PROG' or e.JOB_ID='SA_MAN';

--select * from employees where EMPLOYEE_ID =150 or EMPLOYEE_ID=160;

--select FIRST_NAME, SALARY,COMMISSION_PCT,HIRE_DATE from employees where  SALARY<10000;

--select EMPLOYEE_ID,FIRST_NAME,LAST_NAME from employees where FIRST_NAME like 'S%' or LAST_NAME like 'S%';

--select * from jobs order by JOB_TITLE desc;

--select * from employees where DEPARTMENT_ID=30 and COMMISSION_PCT=0 and SALARY between 5000 and 10000;

--select e.FIRST_NAME,e.EMAIL from employees e full outer join departments d on e.DEPARTMENT_ID=d.DEPARTMENT_ID where DEPARTMENT_NAME= 'Executive';

--select distinct(COUNTRY_ID) from locations;

--select FIRST_NAME,LAST_NAME,JOB_ID from employees where JOB_ID='IT_PROG' or JOB_ID='FI_ACCOUNT';

--select COUNTRY_NAME from countries order by COUNTRY_NAME asc;

