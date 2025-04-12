# Практические задания по LINQ: Социальная сеть

## Исходные данные

### Классы

```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string City { get; set; }
    public int FollowersCount { get; set; }
    public DateTime RegisterDate { get; set; }
    public bool IsActive { get; set; }
}

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public int LikesCount { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsPublic { get; set; }
}

public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public int LikesCount { get; set; }
}

public class Like
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public DateTime CreatedDate { get; set; }
}
```

### Тестовые данные

```csharp
var users = new List<User>
{
    new User { Id = 1, Username = "alex_cool", City = "Москва", FollowersCount = 150, RegisterDate = new DateTime(2023, 1, 15), IsActive = true },
    new User { Id = 2, Username = "maria_smith", City = "Санкт-Петербург", FollowersCount = 320, RegisterDate = new DateTime(2023, 2, 20), IsActive = true },
    new User { Id = 3, Username = "john_doe", City = "Москва", FollowersCount = 90, RegisterDate = new DateTime(2023, 3, 10), IsActive = false },
    new User { Id = 4, Username = "kate_wilson", City = "Казань", FollowersCount = 280, RegisterDate = new DateTime(2023, 4, 5), IsActive = true },
    new User { Id = 5, Username = "mike_brown", City = "Москва", FollowersCount = 420, RegisterDate = new DateTime(2023, 5, 1), IsActive = true }
};

var posts = new List<Post>
{
    new Post { Id = 1, UserId = 1, Content = "Привет всем!", LikesCount = 25, CreatedDate = new DateTime(2023, 6, 1), IsPublic = true },
    new Post { Id = 2, UserId = 2, Content = "Отличный день!", LikesCount = 45, CreatedDate = new DateTime(2023, 6, 2), IsPublic = true },
    new Post { Id = 3, UserId = 1, Content = "Личный пост", LikesCount = 10, CreatedDate = new DateTime(2023, 6, 3), IsPublic = false },
    new Post { Id = 4, UserId = 3, Content = "Новости дня", LikesCount = 15, CreatedDate = new DateTime(2023, 6, 4), IsPublic = true },
    new Post { Id = 5, UserId = 4, Content = "Мое хобби", LikesCount = 35, CreatedDate = new DateTime(2023, 6, 5), IsPublic = true }
};

var comments = new List<Comment>
{
    new Comment { Id = 1, PostId = 1, UserId = 2, Content = "Супер!", CreatedDate = new DateTime(2023, 6, 1), LikesCount = 5 },
    new Comment { Id = 2, PostId = 1, UserId = 3, Content = "Класс!", CreatedDate = new DateTime(2023, 6, 1), LikesCount = 3 },
    new Comment { Id = 3, PostId = 2, UserId = 1, Content = "Согласен!", CreatedDate = new DateTime(2023, 6, 2), LikesCount = 7 },
    new Comment { Id = 4, PostId = 4, UserId = 5, Content = "Интересно", CreatedDate = new DateTime(2023, 6, 4), LikesCount = 4 },
    new Comment { Id = 5, PostId = 5, UserId = 2, Content = "Круто!", CreatedDate = new DateTime(2023, 6, 5), LikesCount = 6 }
};

var likes = new List<Like>
{
    new Like { Id = 1, UserId = 1, PostId = 2, CreatedDate = new DateTime(2023, 6, 2) },
    new Like { Id = 2, UserId = 2, PostId = 1, CreatedDate = new DateTime(2023, 6, 1) },
    new Like { Id = 3, UserId = 3, PostId = 1, CreatedDate = new DateTime(2023, 6, 1) },
    new Like { Id = 4, UserId = 4, PostId = 2, CreatedDate = new DateTime(2023, 6, 2) },
    new Like { Id = 5, UserId = 5, PostId = 4, CreatedDate = new DateTime(2023, 6, 4) }
};
```

## Задания

### Задача 1
Получить всех пользователей из города "Москва".

Решение:
```csharp
var result = users
    .Where(u => u.City == "Москва")
    .ToList();
```

### Задача 2
Найти все публичные посты.

Решение:
```csharp
var result = posts
    .Where(p => p.IsPublic)
    .ToList();
```

### Задача 3
Получить количество комментариев к посту с Id = 1.

Решение:
```csharp
var result = comments
    .Count(c => c.PostId == 1);
```

### Задача 4
Получить список имен всех активных пользователей.

Решение:
```csharp
var result = users
    .Where(u => u.IsActive)
    .Select(u => u.Username)
    .ToList();
```

### Задача 5
Найти первого пользователя из Москвы с более чем 200 подписчиками.

Решение:
```csharp
var result = users
    .FirstOrDefault(u => u.City == "Москва" && u.FollowersCount > 200);
```

### Задача 6
Подсчитать количество постов каждого пользователя.

Решение:
```csharp
var result = users
    .Select(u => new 
    {
        Username = u.Username,
        PublicPostsCount = posts.Count(p => p.UserId == u.Id)
    })
    .ToList();
```

### Задача 7
Получить последние 3 поста пользователя с Id = 2.

Решение:
```csharp
var result = posts
    .Where(p => p.UserId == 2)
    .OrderByDescending(p => p.CreatedDate)
    .Take(3)
    .ToList();
```

### Задача 8
Получить список всех постов с именами их авторов, у которых больше 100 лайков.

Решение:
```csharp
var result = posts
    .Where(p => p.LikesCount > 100)
    .Join(users,
        p => p.UserId,
        u => u.Id,
        (p, u) => new
        {
            PostContent = p.Content,
            Author = u.Username,
            LikesCount = p.LikesCount
        })
    .OrderByDescending(x => x.LikesCount)
    .ToList();
```

### Задача 9
Получить список постов с именами их авторов и количеством комментариев, отсортированный по количеству комментариев.

Решение:
```csharp
var result = posts
    .Join(users,
        p => p.UserId,
        u => u.Id,
        (p, u) => new
        {
            PostContent = p.Content,
            AuthorName = u.Username,
            CommentsCount = comments.Count(c => c.PostId == p.Id)
        })
    .OrderByDescending(x => x.CommentsCount)
    .ToList();
```

### Задача 10
Сгруппировать пользователей по городам и вывести количество пользователей в каждом городе.

Решение:
```csharp
var result = users
    .GroupBy(u => u.City)
    .Select(g => new
    {
        City = g.Key,
        ActiveUsers = g.Count(u => u.IsActive),
        InactiveUsers = g.Count(u => !u.IsActive),
        TotalUsers = g.Count()
    })
    .OrderByDescending(x => x.TotalUsers)
    .ToList();