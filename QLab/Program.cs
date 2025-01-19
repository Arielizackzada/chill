
namespace QLab;
public class Program
    // אריאל יהודה יצחק זדה  - 19.1.25

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Queue<int> q = new Queue<int>();
        q.Insert(7);
        q.Insert(10);
        q.Insert(3);
        Console.WriteLine(q);
        Queue<int> qCopy = SetQCopy(q);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        q.Insert(7);
        qCopy.Insert(13);
        q.Insert(14);
        q.Insert(7);
        q.Insert(20);

        Queue<int> q2 = new Queue<int>();

        q2.Insert(1);
        q2.Insert(3);
        q2.Insert(1);
        q2.Insert(-1);

        bool checkPerfect = CheckQPerfect(q2);
        Console.WriteLine(checkPerfect);
        Console.WriteLine(q2);

        bool check = CheckAround(q, 5);

        Console.WriteLine(check);

        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        Queue<int> q3 = new Queue<int>();
        q3.Insert(7);
        q3.Insert(10);
        q3.Insert(17);
        q3.Insert(20);
        Queue<int> newQ = OrderQueue(q3, 5);
        Console.WriteLine(newQ);
    }


    public static Queue<int> SetQCopy(Queue<int> q)
    {
        Queue<int> qCopy = new();
        Queue<int> qTemp = new();
        int currItem;
        //פריקת התור המקורי ויצירת תור העתק ותור זמני
        while (!q.IsEmpty())
        {
            currItem = q.Remove();
            qTemp.Insert(currItem);
            qCopy.Insert(currItem);
        }
        //שחזור התור המקורי
        while (!qTemp.IsEmpty())
        {
            q.Insert(qTemp.Remove());
        }
        return qCopy;
    }

    public static bool CheckAround(Queue<int> q, int place)
    {

        bool check = false;
        int right = 0;
        int sum = 0;
        int current = 0;
        Queue<int> qCopy = SetQCopy(q);
        Queue<int> qCopy2 = SetQCopy(q);
        int count = 0;

        while (!qCopy2.IsEmpty())
        {
            count++;
            qCopy2.Remove();
        }

        if (place < count && place > 1)
        {
            for (int i = 1; i < place; i++)
            {
                right = qCopy.Remove();
            }


            current = qCopy.Remove();
            sum = qCopy.Remove() + right;

            if (current == sum)
            {
                check = true;
            }
        }

        return check;
    }

    public static bool CheckQPerfect(Queue<int> q)
    {
        Queue<int> qCopy = SetQCopy(q);
        int length = 0;
        int count = 0;

        while (!qCopy.IsEmpty())
        {
            length++;
            qCopy.Remove();
        }

        for (int place = 2; place < length; place++)
        {
            if (CheckAround(q, place))
            {
                count++;
            }
        }
        if (count == length - 2)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
    public static Queue<int> OrderQueue(Queue<int> q,int numToPut) 
    {
        Queue<int> qCopy = SetQCopy(q);
        Queue<int> queue = new Queue<int>();
        bool checkIfPut = false;
        int currentNum = 0;
        while (!qCopy.IsEmpty()) 
        {
            currentNum = qCopy.Remove();
            if ((currentNum > numToPut) && (checkIfPut = false))
            {
                queue.Insert(numToPut);
                queue.Insert(currentNum);
                checkIfPut = true;
                Console.WriteLine("bbbbbbbbbb");
            }
            else 
            {
               queue.Insert(currentNum);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            }
        }
        if (!checkIfPut) 
        {
            queue.Insert(numToPut);
        }
        return queue;
    }
}