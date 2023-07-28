using System.Diagnostics;

namespace ToddCSharpConsoleAppPlayground.AsyncAndAwait
{
    /*
        Asynchronous Programming
    
        Asynchronous Programming is a means of parallel programming in which a unit of work runs separately from the main application.

        Async

        The asynch modifier/keyword is used to specify that a method is asynchronous

        Await

        The await operator/keyword suspends evaluation of the async mtethod until the asynchronous operation completes

        Task

        Represents an asyncronous operation.


        Breakfast Tasks

        1.  Pour Coffee                 1.
        2.  Heat Flattop                2.
        6.  Toast Bread                 2.
        4.  Fry Bacon                   3.
        5.  Cook Sausage                3.
        3.  Cook Eggs                   4.
        4.  Eggs Done                   5.
        5.  ToastDone                   6.
        7.  Butter and Jam on Bread     7.
        8.  Pour Juice                  8.
    */
    public class BreakfastExample
    {
        private static void BrewCoffee(int workMilliseconds)
        {
            Console.WriteLine("Brewing coffee");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Coffee brewed.");
            Console.WriteLine($"");
        }

        private static void PourCoffee(int workMilliseconds)
        {
            Console.WriteLine("Pouring coffee");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Coffee poured. Enjoy!");
            Console.WriteLine($"");
        }

        private static async Task BrewCoffeeAsync(int workMilliseconds)  // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Brewing coffee");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Coffee brewed.");
                Console.WriteLine($"");
            });
        }

        private static async Task PourCoffeeAsync(int workMilliseconds)  // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Pouring coffee");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Coffee poured. Enjoy!");
                Console.WriteLine($"");
            });
        }

        private static void HeatFlattop(int workMilliseconds)
        {
            Console.WriteLine("Heating up the Flattop.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Flattop ready to go!");
            Console.WriteLine($"");
        }

        private static async Task HeatFlattopAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Heating up the Flattop.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Flattop ready to go!");
                Console.WriteLine($"");
            });
        }

        private static void ToastBread(int workMilliseconds)
        {
            Console.WriteLine("About to make toast.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Toast is Ready!");
            Console.WriteLine($"");
        }

        private static async Task ToastBreadAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("About to make toast.");
                DoTheWork(workMilliseconds);
                Console.WriteLine($"Current Thread: {Environment.CurrentManagedThreadId}.");
                Console.WriteLine("Toast is Ready!");
                Console.WriteLine($"");
            });
        }

        private static void PutButterAndJamOnToast(int workMilliseconds)
        {
            Console.WriteLine("Ready to put butter and jam on the toast.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Toast is buttered and jammed!");
            Console.WriteLine($"");
        }

        private static async Task PutButterAndJamOnToastAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to put butter and jam on the toast.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Toast is buttered and jammed!");
                Console.WriteLine($"");
            });
        }

        private static void CookBacon(int workMilliseconds)
        {
            Console.WriteLine("Ready to cook bacon.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Bacon is cooked!");
            Console.WriteLine("");
        }

        private static async Task CookBaconAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to cook bacon.");
                DoTheWork(workMilliseconds);
                Console.WriteLine($"Current Thread: {Environment.CurrentManagedThreadId}.");
                Console.WriteLine("Bacon is cooked!");
                Console.WriteLine("");
            });
        }

        private static void CookSausage(int workMilliseconds)
        {
            Console.WriteLine("Ready to cook sausage.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Sausage is cooked!");
            Console.WriteLine($"");
        }

        private static async Task CookSausageAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to cook sausage.");
                DoTheWork(workMilliseconds);
                Console.WriteLine($"Current Thread: {Environment.CurrentManagedThreadId}.");
                Console.WriteLine("Sausage is cooked!");
                Console.WriteLine($"");
            });
        }

        private static void PlateBacon(int workMilliseconds)
        {
            Console.WriteLine("Ready to plate bacon.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Bacon is on the plate!");
            Console.WriteLine($"");
        }

        private static async Task PlateBaconAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to plate bacon.");
                DoTheWork(workMilliseconds);
                Console.WriteLine($"Current Thread: {Environment.CurrentManagedThreadId}.");
                Console.WriteLine("Bacon is on the plate!");
                Console.WriteLine($"");
            });
        }

        private static void PlateSausage(int workMilliseconds)
        {
            Console.WriteLine("Ready to plate sausage.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Sausage is plated!");
            Console.WriteLine($"");
        }

        private static async Task PlateSausageAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to plate sausage.");
                DoTheWork(workMilliseconds);
                Console.WriteLine($"Current Thread: {Environment.CurrentManagedThreadId}.");
                Console.WriteLine("Sausage is plated!");
                Console.WriteLine($"");
            });
        }

        private static void PlateToast(int workMilliseconds)
        {
            Console.WriteLine("Ready to plate toast.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Toast is plated!");
            Console.WriteLine($"");
        }

        private static async Task PlateToastAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to plate toast.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Toast is plated!");
                Console.WriteLine($"");
            });
        }

        private static void CookEggs(int workMilliseconds)
        {
            Console.WriteLine("Ready to cook eggs.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Eggs are cooked!");
            Console.WriteLine($"");
        }

        private static async Task CookEggsAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to cook eggs.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Eggs are cooked!");
                Console.WriteLine($"");
            });
        }

        private static void PlateEggs(int workMilliseconds)
        {
            Console.WriteLine("Ready to plate eggs.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Eggs are plated!");
            Console.WriteLine($"");
        }

        private static async Task PlateEggsAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to plate eggs.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Eggs are plated!");
                Console.WriteLine($"");
            });
        }

        private static void PourJuice(int workMilliseconds)
        {
            Console.WriteLine("Ready to pour juice.");
            DoTheWork(workMilliseconds);
            Console.WriteLine("Juice is poured!");
            Console.WriteLine($"");
        }

        private static async Task PourJuiceAsync(int workMilliseconds) // It is an accepted convention to add the suffix Async to asynchronous methods
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ready to pour juice.");
                DoTheWork(workMilliseconds);
                Console.WriteLine("Juice is poured!");
                Console.WriteLine($"");
            });
        }

        private static void DoTheWork(int milliseconds)
        {
            //Task.Delay(milliseconds);
        }

        public static async Task MakeBreakfastParallelAsync()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Begin preparing breakfast asychronously.");
            Console.WriteLine("");
            Stopwatch w = new Stopwatch();
            w.Start();
            await BrewCoffeeAsync(10000);
            w.Stop();
            Console.WriteLine($"Elapsed Time for brewing coffee was: {w.ElapsedMilliseconds}.");
            //await brewCoffee;

            //**************************************************************************************
            // Kick off these tasks in parallel
            List<Task> tasks = new List<Task>
            {
                Task.Run(() => HeatFlattop(2000)),
                Task.Run(() => ToastBread(4000))
            };
            // Subsequent tasks depend on the completion of these tasks, so wait for them to finish
            await Task.WhenAll(tasks);

            //**************************************************************************************
            // Kick of these cooking/preparation tasks in parallel
            tasks = new List<Task>
            {
                Task.Run(() => PutButterAndJamOnToast(4500)),
                Task.Run(() => CookBacon(4200)), 
                Task.Run(() => CookSausage(5200)) 
            };
            // Subsequent tasks depend on the completion of these, so wait for all of them to finish to continue
            await Task.WhenAll(tasks);

            //*************************************************************************************
            // Kick off these plating tasks in parallel
            tasks = new List<Task> 
            { 
                Task.Run(() => PlateBacon(2000)), 
                Task.Run(() => PlateSausage(1800)), 
                Task.Run(() => PlateToast(5200)) 
            };
            // Subsequent tasks depend on the completion of all of these.  Wait until they are all done before continuing.
            await Task.WhenAll(tasks);

            //**************************************************************************************
            // Kick off these plating tasks in parallel
            tasks = new List<Task> 
            { 
                Task.Run(() => CookEggs(5000)), 
                Task.Run(() => PourJuice(3500)) 
            };
            // Subsequent tasks depend on the completion of all of these.  Wait until they are all done before continuing.
            await Task.WhenAll(tasks);

            //**************************************************************************************

            // Kick off the cooking of the eggs and wait for it to complete
            await Task.Run(() => PlateEggs(3800));

            /*
            // Finally, Pour the nice, flavorful hot Coffee
            if (brewCoffee.Status == TaskStatus.RanToCompletion)
            {
                await Task.Run(() => PourCoffee(2000));
            }
            else if (brewCoffee.Status == TaskStatus.Running)
            {
                await brewCoffee;
            }
            */

            sw.Stop();
            Console.WriteLine($"Asynchronous Breakfast is served!  It was prepared in {sw.ElapsedMilliseconds} seconds.");
        }

        private static void WriteTaskStatus(string taskName, TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.Canceled:
                    Console.WriteLine($"{taskName} was canceled.");
                    break;
                case TaskStatus.Faulted:
                    Console.WriteLine($"{taskName} faulted.");
                    break;
                case TaskStatus.RanToCompletion:
                    Console.WriteLine($"{taskName} ran to completion.");
                    break;
                case TaskStatus.Running:
                    Console.WriteLine($"{taskName} is still running.  How did I get here?");
                    break;
                case TaskStatus.WaitingForChildrenToComplete:
                    Console.WriteLine($"{taskName} is waiting for children to complete.  How did I get here?");
                    break;
                case TaskStatus.WaitingForActivation:
                    Console.WriteLine($"{taskName} is waiting for activation.  How did I get here?");
                    break;
                case TaskStatus.WaitingToRun:
                    Console.WriteLine($"{taskName} is waiting to run.  How did I get here?");
                    break;
                default:
                    Console.WriteLine("UNKNOWN Task Status received.");
                    break;
            }

            Console.WriteLine("");
        }
    }
}
