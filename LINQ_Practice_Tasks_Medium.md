# Практические задачи по LINQ 

## Задача 1: Группировка и агрегация заказов
```csharp
public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
}

// Пример данных:
var orders = new List<Order>
{
    new Order { Id = 1, CustomerName = "Иван", OrderDate = new DateTime(2024, 1, 15), Amount = 1200.50m, Category = "Электроника" },
    new Order { Id = 2, CustomerName = "Мария", OrderDate = new DateTime(2024, 1, 15), Amount = 850.75m, Category = "Книги" },
    new Order { Id = 3, CustomerName = "Иван", OrderDate = new DateTime(2024, 1, 16), Amount = 2100.00m, Category = "Электроника" },
    new Order { Id = 4, CustomerName = "Анна", OrderDate = new DateTime(2024, 1, 16), Amount = 450.30m, Category = "Книги" }
};
```
Сгруппировать заказы по категориям и дате, вычислить общую сумму заказов для каждой группы и отсортировать результаты по убыванию суммы.

## Задача 2: Объединение коллекций
```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
}

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Grade
{
    public int StudentId { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }
}

// Пример данных:
var students = new List<Student>
{
    new Student { Id = 1, Name = "Иван Петров", GroupId = 1 },
    new Student { Id = 2, Name = "Мария Иванова", GroupId = 2 },
    new Student { Id = 3, Name = "Петр Сидоров", GroupId = 1 }
};

var groups = new List<Group>
{
    new Group { Id = 1, Name = "ПО-42" },
    new Group { Id = 2, Name = "ИС-41" }
};

var grades = new List<Grade>
{
    new Grade { StudentId = 1, Subject = "Математика", Score = 5 },
    new Grade { StudentId = 1, Subject = "Физика", Score = 4 },
    new Grade { StudentId = 2, Subject = "Математика", Score = 5 },
    new Grade { StudentId = 3, Subject = "Физика", Score = 3 }
};
```
Получить список студентов с их группами и средним баллом по всем предметам. Отсортировать по среднему баллу (по убыванию).

## Задача 3: Работа с вложенными коллекциями
```csharp
public class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public List<Skill> Skills { get; set; }
}

public class Skill
{
    public string Name { get; set; }
    public int Level { get; set; }
}

// Пример данных:
var departments = new List<Department>
{
    new Department 
    { 
        Name = "Разработка",
        Employees = new List<Employee>
        {
            new Employee 
            { 
                Name = "Иван",
                Skills = new List<Skill>
                {
                    new Skill { Name = "C#", Level = 5 },
                    new Skill { Name = "SQL", Level = 4 }
                }
            },
            new Employee
            {
                Name = "Мария",
                Skills = new List<Skill>
                {
                    new Skill { Name = "Python", Level = 4 },
                    new Skill { Name = "C#", Level = 3 }
                }
            }
        }
    }
};
```
Найти всех сотрудников, у которых есть навык C# с уровнем выше 3, и сгруппировать их по отделам.

## Задача 4: Обработка временных рядов
```csharp
public class StockPrice
{
    public DateTime Date { get; set; }
    public string Symbol { get; set; }
    public decimal Price { get; set; }
}

// Пример данных:
var stockPrices = new List<StockPrice>
{
    new StockPrice { Date = new DateTime(2024, 1, 1), Symbol = "AAPL", Price = 150.00m },
    new StockPrice { Date = new DateTime(2024, 1, 2), Symbol = "AAPL", Price = 155.00m },
    new StockPrice { Date = new DateTime(2024, 1, 3), Symbol = "AAPL", Price = 153.00m },
    new StockPrice { Date = new DateTime(2024, 1, 1), Symbol = "GOOGL", Price = 2500.00m },
    new StockPrice { Date = new DateTime(2024, 1, 2), Symbol = "GOOGL", Price = 2550.00m },
    new StockPrice { Date = new DateTime(2024, 1, 3), Symbol = "GOOGL", Price = 2480.00m }
};
```
Рассчитать для каждого символа: минимальную цену, максимальную цену, среднюю цену и процент изменения между первым и последним днем.

## Задача 5: Анализ текста
```csharp
public class Document
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string[] Tags { get; set; }
}

// Пример данных:
var documents = new List<Document>
{
    new Document 
    { 
        Id = 1, 
        Title = "C# Основы", 
        Content = "C# является объектно-ориентированным языком программирования",
        Tags = new[] { "программирование", "c#", "основы" }
    },
    new Document 
    { 
        Id = 2, 
        Title = "LINQ Tutorial", 
        Content = "LINQ - это набор методов для работы с данными в C#",
        Tags = new[] { "c#", "linq", "tutorial" }
    }
};
```
Найти все документы, которые содержат определенное слово в контенте или тегах, и вернуть список с заголовками и совпадающими тегами.

## Задача 6: Обработка транзакций
```csharp
public class Transaction
{
    public int Id { get; set; }
    public string AccountId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Category { get; set; }
}

// Пример данных:
var transactions = new List<Transaction>
{
    new Transaction { Id = 1, AccountId = "ACC1", Amount = 100.00m, Date = new DateTime(2024, 1, 1), Category = "Продукты" },
    new Transaction { Id = 2, AccountId = "ACC1", Amount = -50.00m, Date = new DateTime(2024, 1, 2), Category = "Транспорт" },
    new Transaction { Id = 3, AccountId = "ACC2", Amount = 200.00m, Date = new DateTime(2024, 1, 1), Category = "Зарплата" },
    new Transaction { Id = 4, AccountId = "ACC2", Amount = -75.00m, Date = new DateTime(2024, 1, 2), Category = "Продукты" }
};
```
Рассчитать баланс для каждого аккаунта, сгруппировать транзакции по категориям и вычислить процентное соотношение расходов по категориям.

## Задача 7: Анализ логов
```csharp
public class LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Level { get; set; }  // "ERROR", "WARNING", "INFO"
    public string Service { get; set; }
    public string Message { get; set; }
}

// Пример данных:
var logs = new List<LogEntry>
{
    new LogEntry { Timestamp = new DateTime(2024, 1, 1, 10, 0, 0), Level = "ERROR", Service = "API", Message = "Connection failed" },
    new LogEntry { Timestamp = new DateTime(2024, 1, 1, 10, 0, 5), Level = "WARNING", Service = "DB", Message = "Slow query detected" },
    new LogEntry { Timestamp = new DateTime(2024, 1, 1, 10, 1, 0), Level = "ERROR", Service = "API", Message = "Timeout" },
    new LogEntry { Timestamp = new DateTime(2024, 1, 1, 10, 2, 0), Level = "INFO", Service = "Cache", Message = "Cache cleared" }
};
```
Проанализировать логи: найти сервисы с наибольшим количеством ошибок, сгруппировать ошибки по временным интервалам (по минутам) и вычислить частоту различных типов ошибок.

## Задача 8: Обработка заказов с пагинацией
```csharp
public class OrderItem
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

// Пример данных:
var orderItems = new List<OrderItem>
{
    new OrderItem { OrderId = 1, ProductName = "Телефон", Quantity = 1, Price = 1000.00m },
    new OrderItem { OrderId = 1, ProductName = "Чехол", Quantity = 2, Price = 10.00m },
    new OrderItem { OrderId = 2, ProductName = "Ноутбук", Quantity = 1, Price = 2000.00m },
    new OrderItem { OrderId = 2, ProductName = "Мышь", Quantity = 1, Price = 50.00m }
};
```
Реализовать пагинацию заказов: сгруппировать товары по заказам, вычислить общую сумму каждого заказа и вернуть указанную страницу результатов с заданным размером страницы.

## Задача 9: Анализ продаж
```csharp
public class Sale
{
    public int Id { get; set; }
    public string Region { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal Revenue { get; set; }
    public DateTime Date { get; set; }
}

// Пример данных:
var sales = new List<Sale>
{
    new Sale { Id = 1, Region = "Север", Product = "A", Quantity = 10, Revenue = 1000.00m, Date = new DateTime(2024, 1, 1) },
    new Sale { Id = 2, Region = "Юг", Product = "B", Quantity = 5, Revenue = 500.00m, Date = new DateTime(2024, 1, 1) },
    new Sale { Id = 3, Region = "Север", Product = "A", Quantity = 15, Revenue = 1500.00m, Date = new DateTime(2024, 1, 2) },
    new Sale { Id = 4, Region = "Восток", Product = "C", Quantity = 8, Revenue = 800.00m, Date = new DateTime(2024, 1, 2) }
};
```
Проанализировать продажи по регионам: найти топ-продукты по выручке в каждом регионе, вычислить динамику продаж по дням и определить регионы с наибольшим ростом продаж.

## Задача 10: Обработка опросов
```csharp
public class Survey
{
    public int Id { get; set; }
    public string Question { get; set; }
    public List<Answer> Answers { get; set; }
}

public class Answer
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public string UserResponse { get; set; }
    public int Rating { get; set; }
    public DateTime SubmissionDate { get; set; }
}

// Пример данных:
var surveys = new List<Survey>
{
    new Survey 
    { 
        Id = 1, 
        Question = "Как вы оцениваете наш сервис?",
        Answers = new List<Answer>
        {
            new Answer { Id = 1, SurveyId = 1, UserResponse = "Отлично", Rating = 5, SubmissionDate = new DateTime(2024, 1, 1) },
            new Answer { Id = 2, SurveyId = 1, UserResponse = "Хорошо", Rating = 4, SubmissionDate = new DateTime(2024, 1, 2) }
        }
    },
    new Survey
    {
        Id = 2,
        Question = "Порекомендуете ли вы нас друзьям?",
        Answers = new List<Answer>
        {
            new Answer { Id = 3, SurveyId = 2, UserResponse = "Да", Rating = 5, SubmissionDate = new DateTime(2024, 1, 1) },
            new Answer { Id = 4, SurveyId = 2, UserResponse = "Возможно", Rating = 3, SubmissionDate = new DateTime(2024, 1, 2) }
        }
    }
};
```
Проанализировать результаты опросов: вычислить средний рейтинг по каждому вопросу, найти наиболее популярные ответы и проанализировать тренды в оценках по времени.
