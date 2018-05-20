## Ricardo Rosa

### ISTA420 T-SQL

### Homework 11

***Page 361***

#### 1. Why do we use variables in T-SQL? How do you declare and initialize T-SQL variables?
You use variables to temporarily store data values for later use in the same batch in which they were declared.

Use a DECLARE statement to declare one or more variables, and use a SET statement to assign a value to a single variable

#### 2. Describe what is meant by a batch file in T-SQL? What is the difference between batches and transactions?
A batch is one or more T-SQL statements sent by a client application to SQL Server for execution as a single unit.

A transaction is an atomic unit of work

A batch can have multiple transactions, and a transaction can be submitted in parts as multiple batches.

#### 3. What is the scope of variables with respect to T-SQL batches?


#### 4. Write a T-SQL code snippet that returns a data element stating whether the current person can legally purchase alcohol, that is, has reached his 21st birthday.


#### 5. (Not in book) Does T-SQL have a for loop construction?
No. It has a while loop

#### 6. What is a cursor? What is the difference between a relation and a cursor?
a nonrelational result with order guaranteed among rows.

#### 7. How do you declare a temporary table? Why would you declare a temporary table?
Declare @Temp


When you need to temporarily store data in tables
you need the data to be visible only to the current session, or even only to the current batch.

#### 8. What is the difference between a stored procedure, a user defined function, and a trigger?
A Stored procedure is a set of sql statements with a given name , which is physically stored in database in the compiled form.

User defined function is a database object which encapsulates one or more sql statements for reuse , which can accept zero or more parameters and return either a value or table.

#### 9. Write a user defined function that returns a Booleans as to whether a customer may purchase alcohol as of the instant that the function runs.


#### 10. Write a trigger that places a customer in the OFF LIMITS table if he attempt to purchase alcohol when he is underage.


#### 11. Write a stored procedure that deletes customers from the OFF LIMITS table when they have reached their 21st birthday

