## Ricardo Rosa

### ISTA421 Homework 20

### C# 


***pages 439 – 466 in the C# Step by Step book.***

#### 1. What is a delegate? Explain delegates in terms of pointers and reference types.
A delegate is a reference to a method.

references type - you can assign a reference to a method to a delegate in much the same way that you can assign and int value to an int variable.

pointers - delegates are similar to function pointers; but delegates are completely type safe.

You can make a delegate refer only to a method that matches the signature of the delegate, and you can't invoke a delegate that does not refer to a valid method.

#### 2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
Delegates are declared using the "delegate" keyword.

    public delegate void MyDelegate(string text);

You can declare a delegate that can appear on its own or even nested inside a class.



#### 3. How do you create instances of delegates and assign values to the instance? What are the values?
Use the same syntax you use for a class or structure: write the keyword new, followed by the name of the type (the name of the delegate), followed by the argument between the parentheses. The argument must be a method whose signature exactly matches the signature of the delegate.

#### 4. How do you invoke a method that has been added to a delegate?
You can invoke any numbers of methods indirectly by using delegates.

using the same syntax as method I.E. 

    myDelegate;
    ...
    del();

#### 5. What is an event? Why do we have events?
Defines and traps significant actions and arrange for a delegate to be called to handle the situation.

so when the user clicks a button or types something in a field.

#### 6. How do you declare events?
You declare an event similarly to how you declare a field. But the type of an event must be a delegate, and you must prefix the declaration with the event keyword.


    event delegateTypeName eventName

write the keyword event, followed by the name of the type (the type must be a delegate type), followed by the name of the event I.E.

    Class MyClass
    {
    	public delegate void MyDelegate();
    	...
    	public event myDelegate MyEvent;
    }

#### 7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
Create a delegate instance, and attach the delegate instance to the event using the += operator

and unsubscribe with the -= operator

#### 8. How do you raise an event? How do you declare code that raises an event?
You can raise an event by calling it like a method. You must supply arguments to match the type of the parameters expected by the delegate reference by the event

when you raise an event, all the attached delegates are called in sequence.

#### 9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
When an Event fire the delegate runs the code 
