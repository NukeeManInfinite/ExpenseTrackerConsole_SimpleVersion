using System.Text;

namespace ExpenseTrackerConsoleAppSimple
{
    internal class Program
    {
        static List<Expense> Expenses = new List<Expense>();
        static void Main(string[] args)
        {

            Run();
        }

        public static void Run()
        {
            string stop;
            while (true)
            {
                Expense expense = new Expense();

                Console.Write("Expense Name: ");
                expense.Name = Console.ReadLine();

                Console.Write("Amount: ");
                expense.Amount = int.Parse(Console.ReadLine());

                Console.Write("Time: ");
                expense.Time = TimeOnly.Parse(Console.ReadLine());


                Console.Write("\nHit enter to add expense ...\n");

                stop = Console.ReadLine();

                Expenses.Add(expense);

                if (stop == "stop")
                {
                    ShowTable();
                    break;
                }


            }
        }

        public static void ShowTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            CreateLines();
            strBuilder.AppendFormat($"| {"Expense",-10} | {"Amount",-10} | {"Date",-10} |");
            CreateLines();


            foreach (Expense expense in Expenses)
            {
                strBuilder.AppendFormat($"| {expense.Name,-10} | {expense.Amount,-10} | {expense.Time.ToString(),-10} |");

                CreateLines();


            }

            Console.WriteLine(strBuilder.ToString());




            void CreateLines()
            {
                strBuilder.AppendLine();
                strBuilder.Append(" ");
                for (int i = 0; i < 38; i++) { strBuilder.Append("-"); }
                strBuilder.AppendLine();
            }

        }


    }
}
