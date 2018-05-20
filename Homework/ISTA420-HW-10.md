## Ricardo Rosa

### ISTA420 T-SQL

### Homework 10

***Page 319***


#### 1. What is the purpose of transactions? Why do we use transactions in SQL scripts?
Query, modifies data and can also change the data definition.


#### 2. Briefly describe each of the ACID properties.
Atomicity - A transaction is an atomic unit of work. Either all changes in the transaction take place or none do.

Consistency - The term consistency refers to the state of the data that the relational database management system gives you access to as concurrent transactions modify and query it.

Isolation - Isolation ensures that the transactions access only consistent data. You control what consistency means to your transaction through a mechanism called isolation levels.

Durability - Data changes are always written to the database's transaction log on disk before they are written to the data portion of the database on disk.

#### 3. What do we mean when we talk about the granularity of locks?
The granularity of locks in a database refers to how much of the data is locked at one time.

#### 4. What do we mean when we talk about the modes of locks?
Exclusive and Shared.




#### 5. In your own words, describe blocking, and give an example.



#### 6. What are the properties of locks? That is, list the column name and column type of the fields in sys.dm tran locks.
Research type 

Request mode



#### 7. What are the properties of sessions? That is, list the column name and column type of the fields in sys.dm exec connections.


#### 8. What are the requests of sessions? That is, list the column name and column type of the fields in sys.dm exec requests.


#### 9. What is an isolation level? Give an example of the operation of an isolation level.
defines the degree to which one transaction must be isolated from resource or data modifications made by other transactions.

#### 10. (Not in the book.) What do we mean when we say that an object is serializable?


#### 11. What is an deadlock? Give an example of a deadlock?

A deadlock occurs when two or more processes are waiting on the same resource and each process is waiting on the other process to complete before moving forward.