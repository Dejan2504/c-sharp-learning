
namespace UserModel{
public class User
{
    private static int num {get; set;} = 0;

    public static void AddOne(){
        num += 1;
    }

    public static int GetNum(){
        return num;
    }


}
}




