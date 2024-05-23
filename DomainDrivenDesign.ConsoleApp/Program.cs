//#region Virtual and Override Cache Örneği
////RedisCache redisCache = new RedisCache();
////redisCache.CreateCache();

////abstract class Cache
////{
////    public virtual void CreateCache()
////    {

////    }
////}

////class MemoryCache : Cache
////{
////    public override void CreateCache()
////    {
////        Console.WriteLine("Memory Cache çalıştı");
////    }
////}

////class RedisCache : Cache
////{
////    public override void CreateCache()
////    {
////        //base.CreateCache();
////        Console.WriteLine("Redis Cache çalıştı");
////    }
////}
//#endregion

//#region Override and Virtual
////Test2 test2 = new Test2();
////test2.ChangeSomething();


////class Test2 : Test
////{
////    public override void ChangeSomething()
////    {
////        //base.ChangeSomething();
////        Console.WriteLine("Ben de bu metodun kopyasıyım");
////    }
////}
////class Test
////{
////    public virtual void ChangeSomething()
////    {
////        Console.WriteLine("Ben Serhan Kunt, bu da örnek kodum");
////    }
////}
//#endregion


//User user1 = new()
//{
//    Id = 1,
//    FirstName = "Serhan",
//    LastName = "Kunt",
//    Email = "hserhan006@gmail.com"
//};

//User user2 = new()
//{
//    Id = 1,
//    FirstName = "Serhan",
//    LastName = "Kunt",
//    Email = "hserhan006@gmail.com"
//};

//var result = user1.Equals(user2);
//Console.WriteLine($"User1 user2'ye eşit mi ? :{0} ", result);

//Console.ReadLine();



//public class User
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; } = string.Empty;
//    public string LastName { get; set; } = string.Empty;
//    public string Email { get; set; } = string.Empty;

//    public override bool Equals(object? obj)
//    {
//        if(obj == null) return false;

//        if(obj is not User user) return false;

//        if(obj.GetType() != typeof(User)) return false;

//        return user.Id == Id;  
           
//    }

//    public static bool operator ==(User left , User right)
//    {
//        if(left is null || right is null) return false;
//        if(left.GetType() != right.GetType()) return false; 
//        return left.Id == right.Id;
//    }

//    public static bool operator !=(User left, User right)
//    {
//        if (left is null || right is null) return true;
//        if (left.GetType() != right.GetType()) return true;
//        return left.Id != right.Id;
//    }
//}

//public class Test2
//{
//    public static int operator+(int x, int y)
//    {
//        return x + y;
//    }
//}