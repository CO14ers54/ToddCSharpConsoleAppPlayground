using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.AsyncAndAwait
{
    /*
     https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/ 
    */


    /*
        Basics of C# async await. In this article, you'll learn what C# async and C# await keywords are and how to use async and await in C# code.

        Nowadays, Asynchronous programming is very popular with the help of the async and await keywords in C#. When we are dealing with UI, and on button click, we use a
        long-running method like reading a large file or something else which will take a long time, in that case, the entire application must wait to complete the whole task. 
        In other words, if any process is blocked in a synchronous application, the whole application gets blocked, and our application stops responding until the whole task completes.

        Asynchronous programming is very helpful in this condition. By using Asynchronous programming, the Application can continue with the other work that does not depend on the 
        completion of the entire task.
        We will get all the benefits of traditional Asynchronous programming with much less effort with the help of async and await keywords.

        Suppose we are using two methods as Method1 and Method2 respectively, and both the methods are not dependent on each other, and Method1 takes a long time to complete its 
        task. In Synchronous programming, it will execute the first Method1 and it will wait for the completion of this method, and then it will execute Method2. Thus, it will be 
        a time-intensive process even though both methods are not depending on each other.

        We can run all the methods parallelly by using simple thread programming, but it will block UI and wait to complete all the tasks. To come out of this problem, we have to write 
        too many codes in traditional programming, but if we use the async and await keywords, we will get the solutions in much less code.

        Also, we are going to see more examples, and if any third Method, as Method3 has a dependency of method1, then it will wait for the completion of Method1 with the help of 
        await keyword.
        Async and await in C# are the code markers, which marks code positions from where the control should resume after a task completes.

        Let’s start with practical examples for understanding the programming concept.
    */

    /*
        Use the async modifier to specify that a method, lambda expression, or anonymous method is asynchronous. If you use this modifier on a method or expression, it's referred 
        to as an async method.

        An async method runs synchronously until it reaches its first await expression, at which point the method is suspended until the awaited task is complete. In the meantime, 
        control returns to the caller of the method.

        The async keyword is contextual in that it's a keyword only when it modifies a method, a lambda expression, or an anonymous method. In all other contexts, it's 
        interpreted as an identifier.    

        RETURN TYPES
        An async method can have the following return types:

        Task
        Task<TResult>
        void. async void methods are generally discouraged for code other than event handlers because callers cannot await those methods and must implement a different 
        mechanism to report successful completion or error conditions.
        Any type that has an accessible GetAwaiter method. The System.Threading.Tasks.ValueTask<TResult> type is one such implementation. It is available by adding the NuGet 
        package System.Threading.Tasks.Extensions.  The async method can't declare any in, ref or out parameters, nor can it have a reference return value, but it can call methods
        that have such parameters.

        You specify Task<TResult> as the return type of an async method if the return statement of the method specifies an operand of type TResult. You use Task if no meaningful 
        value is returned when the method is completed. That is, a call to the method returns a Task, but when the Task is completed, any await expression that's awaiting the 
        Task evaluates to void.

        You use the void return type primarily to define event handlers, which require that return type. The caller of a void-returning async method can't await it and can't 
        catch exceptions that the method throws.

        You return another type, typically a value type, that has a GetAwaiter method to minimize memory allocations in performance-critical sections of code.
    */



    public class AsyncAndAwait
    {
        public static void RunAsyncAndAwaitExamples()
        {
            //Example1.RunExample1();
            //Example2.RunExercise2();
            BreakfastExample.MakeBreakfastParallelAsync();
        }
    }
}
