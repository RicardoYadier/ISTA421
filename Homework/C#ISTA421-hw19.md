## Ricardo Rosa

### ISTA421 Homework 19

### C# 



***chapter 19, pages 423 – 438 in the C# Step by Step book.***

#### 1. What is an enumerable collection?
It is a collection that implements the System.Collections.IEnumerable interface.

#### 2. What properties and methods does the IEnumerable interface contain?
One method and it's called GetEnumerator

#### 3. What properties and methods does the IEnumerator interface contain?
    object Current { get; }
    bool MoveNext();
    void Reset();
    

#### 4. What values does the MoveNext() method return? What does it do?
You call the MoveNext method to move the pointer down to the next item in the list. it returns a boolean 

#### 5. What values does the Reset() method return? What does it do?
You use the Reset method to return the pointer back to before the first item in the list.

#### 6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
Not type safeit returns an object rather than a specific type. 


#### 7. Why don’t recursive methods retain state when used with data structures like binary trees?
Recursive algorithms, such as that used when walking a binary tree, do not lend themselves to maintaining state information between method calls in an easily accessible manner.

#### 8. How do you define an enumerator?
Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. However, an enum can also be nested within a class or struct.

#### 9. What is an iterator?
A block of code that yields and ordered sequence of values.

#### 10. What does yield do?
Indicates the value that should be return by each iteration.