namespace doga2;

class Program
{
    static void Print(string s){
        Console.Write(s);
    }

    static void PrintList(int[] list){
        for(int i = 0; i < list.Length; i++){
            Print($"{list[i]} ");
        }
        Print("\n");
    }

    static string Read(){
        return Console.ReadLine();
    }

    static int GetInt(){
        return int.Parse(Read());
    }

    static float GetFloat(){
        return float.Parse(Read());
    }

    static void Wait(){
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        EgyNegy();
        Ot();
        Hat();
        Het();
        Nyolc();
        Wait();
    }

    static void EgyNegy()
    {
        void AB(int[] list)
        {
            int even_count = 0;
            int odd_count = 0;
            int[] even_arr = new int[] { };
            int[] odd_arr = new int[] { };

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    Print("even: " + i + "\n");
                    even_count++;
                }
                else
                {
                    Print("odd: " + i + "\n");
                    odd_count++;
                }
            }
            Print("Even count: " + even_count + "\n");
            Print("Odd count: " + odd_count + "\n");
        }

        void C(int[] list){
            int prim_count = 0;

            for(int i = 0; i < list.Length; i++){
                bool is_prim = true;
                for(int j = 2; j < list[i]; j++){
                    if(list[i] % j == 0){
                        is_prim = false;
                        break;
                    }
                }
                if(is_prim){
                    Print("prim: " + list[i] + "\n");
                    prim_count++;
                }
            }
            Print("Prim count: " + prim_count + "\n");
        }

        double avg(int[] list){
            int sum = 0;
            double avg = 0;
            for(int i = 0; i < list.Length; i++){
                sum += list[i];
            }
            avg = sum / list.Length;
            return (int)avg;
        }
    

        void D(int[] list){
            double temp = avg(list);
            Print("Avg: " + temp + "\n");
        }

        void EF(int[] list){
            int min = list[0];
            int max = list[0];

            for(int i = 0; i < list.Length; i++){
                if(list[i] < min){
                    min = list[i];
                }
                if(list[i] > max){
                    max = list[i];
                }
            }
            Print("Min: " + min + "\n");
            Print("Max: " + max + "\n");
        }

        int n;
        Print("n: ");
        n = GetInt();
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = new Random().Next(0, 100);
        }
        AB(arr);
        C(arr);
        D(arr);
        EF(arr);
    }

    static void Ot(){
        string[] PushToArray(int num){
            string[] arr = new string[num];
            for(int i = 0; i < arr.Length; i++){
                Print("arr[" + i + "]: ");
                arr[i] = Read();
            }
            return arr;
        }

        void A(string[] list){
            string min = list[0];
            for(int i = 0; i < list.Length; i++){
                if(list[i].Length < min.Length){
                    min = list[i];
                }
            }
            Print("Min: " + min + "\n");
        }

        void B(string[] list){
            string max = list[0];
            for(int i = 0; i < list.Length; i++){
                if(list[i].Length > max.Length){
                    max = list[i];
                }
            }
            Print("Max: " + max + "\n");
        }

        void C(string[] list){
            for(int i = 0; i < list.Length; i++){
                for(int j = i + 1; j < list.Length; j++){
                    if(list[i] == list[j]){
                        Print("Egyező szó: " + list[i] + "\n");
                    }
                }
            }
        }

        string[] arr = PushToArray(5);

        A(arr);
        B(arr);
        C(arr);
    }

    static void Hat(){

        int a, b, c, d;
        Print("a: ");
        a = GetInt();
        Print("b: ");
        b = GetInt();
        Print("c: ");
        c = GetInt();
        Print("d: ");
        d = GetInt();

        if(b == 0 || d == 0){
            Print("A nevező nem lehet 0!\n");
        }else{
            int e = a * d + b * c;
            int f = b * d;
            Print("Eredmény: " + e + "/" + f + "\n");
        }
    }
    
    static void Het(){
        int num;
        do{
            Print("Kérek egy páros számot: ");
            num = GetInt();
        }while(num % 2 != 0);
    }

    static void Nyolc(){
        int num;
        do{
            Print("Kérek egy pozitív számot: ");
            num = GetInt();
        }while(num < 0);
        Print("Maradék: " + num % 5 + "\n");
    }
}