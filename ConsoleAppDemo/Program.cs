using ConsoleAppDemo;

//创建委托实例
//DelegateWork dw = new DelegateWork(Work.Manage);
//dw += Work.Design;

//DelegatePlay dp = new DelegatePlay(Play.Train);
//dp += Play.Match;

//Person p1 = new Person("山小福");
//p1.Working(DateTime.Now, dw);
//p1.Play(DateTime.Now, dp, "篮球");

Restaurant restaurant = new Restaurant();
restaurant.EventWaiting += KitchMethod.Restaurant_EventWaiting;
restaurant.EventAfterMake += KitchMethod.Restaurant_EventAfterMake;

restaurant.EventPackaged += KitchMethod.Restaurant_EventPackaged;
restaurant.EventPackaged += KitchMethod.Restaurant_EventPackaged1;

restaurant.Kitchen("小云", "宫保鸡丁");

Console.ReadKey();

