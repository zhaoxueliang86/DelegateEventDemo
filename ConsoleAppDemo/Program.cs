using ConsoleAppDemo;

//创建委托实例
DelegateWork dw = new DelegateWork(Work.Manage);
dw += Work.Design;

DelegatePlay dp = new DelegatePlay(Play.Train);
dp += Play.Match;

Person p1 = new Person("山小福");
p1.Working(DateTime.Now, dw);
p1.Play(DateTime.Now, dp, "篮球");

