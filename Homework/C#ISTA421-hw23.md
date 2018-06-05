## Ricardo Rosa

### ISTA421 Homework 23

### C# 

***Read chapter 23, pages 517 – 558 in the C# Step by Step book.***

#### 1 List two reasons for multitasking, and explain the rationale for them.
To improve responsiveness - so that it can keep doing a set of different functions at the same time.

To improve scalability

#### 2 Explain Moore’s law. What does Moore’s law have to do with multitasking?


#### 3 In UWP, what namespace is used as the container for the multitasking methods?
System.Threading Task

#### 4 What is the difference between tasks and threads? Explain.
tasks is are a class that run a block of code. the tasks are scheduled and executed by using thread objects and the ThreadPool class.

#### 5 What is the ThreadPool?
The Threadpool class implements a number of optimizations and uses a work-stealing algorithm to ensure that threads are schedule efficiently

#### 6 What parameters does the Task() constructor take?
ab Action delegate

#### 7 How do you start a thread?
by using the start() method

#### 8 What is the difference between the Start() and Run() methods?
The start() method is overloaded, and you can optionally specify a TaskCreationOptions object to provide hints about how to schedule the task.

The run() method takes takes an Action delegate specifying the operation to perform, but starts the task running immediately.

#### 9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.
#### 10 Explain how manual cancellation works using a cancellation token.