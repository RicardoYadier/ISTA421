## Ricardo Rosa

### ISTA421 Homework 21

### C# 

***Read chapter 21, pages 469 – 492 in the C# Step by Step book***

#### 1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?
SQL provides a high-level description of the data that the developer wants to retrieve but does not indicate exactly how the database management system should retrieve this data.

LINQ you can change the underlying structure of the data being queried without needing to change the code that actually performs the queries.

Although LINQ looks similar to SQL, it is far more flexible and can handle a wider variety of logical data structures.

#### 2. What is the one essential requirement for the datastructures used with LNQ? Why is this requirement important?
it requires the data to be stored in a data structure that implements the IEnumerable ot IEnumerable<T> interface.

#### 3. Were does the LINQ Select() method live?
In the Enumerable class. The Enumerable class is located in the System.Linq namespace

#### 4. (Select) Explain, token by token, each token in this line of code: IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
Ienumerable is a interface
<string> is a generic type
customerFirstNames is the name
= assignment operator
Customer is an object
First name is the property of the object


#### 5. (Filter) Explain, token by token, each token in this line of code:  IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);


#### 6. (OrderBy) Explain, token by token, each token in this line of code: IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);


#### 7. (Group) Explain, token by token, each token in this line of code: var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);


#### 8. (Distinct) Explain, token by token, each token in this line of code: int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();


#### 9. (Join) Explain, token by token, each token in this line of code: var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country });


#### 10. Explain the difference between a deferred collection and a static, cached collection.