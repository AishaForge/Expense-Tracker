using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ExpenseTracher
{
    internal class Database
    {
        private static string connectionString = "Data Source=ExpensesTracker.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!System.IO.File.Exists("ExpensesTracker.db"))
            {
                SQLiteConnection.CreateFile("ExpensesTracker.db");
            }

            using (SQLiteConnection connection= new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Categories Table

                string categoriesTable = @"

                CREATE TABLE IF NOT EXISTS Categories (

                    category_id INTEGER PRIMARY KEY AUTOINCREMENT,

                    name TEXT NOT NULL UNIQUE

                );";

                // Transactions Table

                string transactionsTable = @"

                CREATE TABLE IF NOT EXISTS Transactions (

                    transaction_id INTEGER PRIMARY KEY AUTOINCREMENT,

                    type TEXT NOT NULL,

                    amount REAL NOT NULL,

                    category_id INTEGER NOT NULL,

                    transaction_date TEXT NOT NULL,

                    description TEXT,

                    FOREIGN KEY (category_id)

                    REFERENCES Categories(category_id)

                );";

                // Budgets Table

                string budgetsTable = @"

                CREATE TABLE IF NOT EXISTS Budgets (

                    budget_id INTEGER PRIMARY KEY AUTOINCREMENT,

                    month INTEGER NOT NULL,

                    year INTEGER NOT NULL,

                    amount REAL NOT NULL,

                    UNIQUE(month, year)

                );";

                // Savings Goals Table

                string savingsGoalsTable = @"

                CREATE TABLE IF NOT EXISTS SavingsGoals (

                    goal_id INTEGER PRIMARY KEY AUTOINCREMENT,

                    goal_name TEXT NOT NULL,

                    target_amount REAL NOT NULL,

                    saved_amount REAL NOT NULL DEFAULT 0

                );";

                // Execute table creation

                using (SQLiteCommand command =

                    new SQLiteCommand(connection))

                {

                    command.CommandText = categoriesTable;

                    command.ExecuteNonQuery();

                    command.CommandText = transactionsTable;

                    command.ExecuteNonQuery();

                    command.CommandText = budgetsTable;

                    command.ExecuteNonQuery();

                    command.CommandText = savingsGoalsTable;

                    command.ExecuteNonQuery();

                }

            }
        }
        
    }
}
