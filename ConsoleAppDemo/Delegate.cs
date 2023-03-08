//
//委托，是对方法的抽象和封装
//
//换种说法来理解，把委托比做一个盒子，这个盒子规定了输入和输出，
//如果方法的输入和输出与盒子匹配，就可以放到这个盒子里一起执行，
//这个盒子就可以看做一个委托
//
//定义委托 delegate 关键字
//泛型委托
//
namespace ConsoleAppDemo
{
    public delegate void DelegateWork();
    public delegate void DelegateWork1(int i, string name);
    public delegate bool DelegateTask();
    public delegate void DelegatePlay(string name);

    public delegate void DelegateG1<T1, T2>(T1 t1, T2 t2);
    public delegate TResult DelegateG2<T1, T2, TResult>(T1 t1, T2 t2);
}
