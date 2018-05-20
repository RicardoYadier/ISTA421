## Ricardo Rosa

### ISTA421 Homework 22

### C# 


***Read chapter 22, pages 493 – 514 in the C# Step by Step book.***


#### 1. Explain the difference between the concepts of associativity and precedence.

The precedence of operators refers to the order in which operators are evaluated within an expression whereas associativity refers to the order in which the consecutive operators within the same group are carried out.

#### 2. Explain the difference between the concepts of binary and unary operators.

A unary operator has just one operand (++)

A binary operator is an operate that has two operands (*)

#### 3. List four constraints imposed by C# with respect to operator overloading.

You cannot change the precedence and associativity of an operator

You cannot change the multiplicity (the number of operands) of an operator.

You cannot invent new operator symbols.

You can't change the meaning of operators when they are applied to built in types.

#### 4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.

you use a method like syntax with a return type and parameters but the name if the method is the keyword operator together with the operator symbol you are declaring.

#### 5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?



#### 6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.
if you have overloaded the simple operator , the overloaded version is automatically called when you use its associated compound assignment operator. so not directly 

#### 7. What is the difference between overloading increment and decrement operators for value types and reference types?


#### 8. Why do we overload some operators in pairs?
Because they come in pairs

#### 9. What is the difference between widening conversion and narrowing conversion?
A widening conversion changes a value to a data type that can allow for any possible value of the original data. A narrowing conversion changes a value to a data type that might not be able to hold some of the possible values.#### 10. What is the difference between explicit conversion and implicit conversion?an Implicit conversion requires no special syntax and never throws an exceptionImplicit conversion sometimes called a widening conversion - contains at least as much information as the original value, and nothing is lost.An explicit conversion sometimes called a narrowing conversion - because is narrower than the original value (contain less value) and can throw OverflowException exception if the resulting value is out of the range of the target type