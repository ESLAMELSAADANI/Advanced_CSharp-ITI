namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Before Registration

            //Ball ball1 = new Ball() { };
            //Console.WriteLine(ball1);// Ball Position - (0 , 0)

            //Player p1 = new Player() { Id = 1, Name = "Eslam" };
            //Player p2 = new Player() { Id = 2, Name = "Abdallah" };
            //Player p3 = new Player() { Id = 3, Name = "Ahmed" };
            //Player p4 = new Player() { Id = 3, Name = "Osama" };

            //ball1.SetPosition(50, 60);
            //Console.WriteLine(ball1);// Ball Position - (50 , 60)

            //ball1.SetPosition(80, 90);
            //Console.WriteLine(ball1);// Ball Position - (80 , 90)

            #endregion

            #region When Registeration || Player With Ball Movement Fire Event that refer to MovePlayer().

            ////When Register Players On Ball To Fire Event(That refer to movePlayer Function) When Ball Position Change
            //Ball ball1 = new Ball() { };
            //Console.WriteLine($"{ball1}\n");// Ball Position - (0 , 0)

            //Player p1 = new Player() { Id = 1, Name = "Eslam" };
            //Player p2 = new Player() { Id = 2, Name = "Abdallah" };
            //Player p3 = new Player() { Id = 3, Name = "Ahmed" };
            //Player p4 = new Player() { Id = 4, Name = "Osama" };
            //Player p5 = new Player() { Id = 5, Name = "Mohamed" };

            ////Registration
            //ball1.OnPositionChanged += p1.MovePlayer;
            //ball1.OnPositionChanged += p2.MovePlayer;
            //ball1.OnPositionChanged += p3.MovePlayer;
            //ball1.OnPositionChanged += p4.MovePlayer;


            //ball1.SetPosition(50, 60);//When Position Change =>
            ////From Player (1 - Eslam) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Player (2 - Abdallah) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Player (3 - Ahmed) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Player (4 - Osama) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (50 , 60)

            //ball1.SetPosition(80, 90);//When Position Change =>
            ////From Player (1 - Eslam) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Player (2 - Abdallah) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Player (3 - Ahmed) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Player (4 - Osama) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (80 , 90)

            //Console.WriteLine($"====== After Replacement p4 with p5 =========");
            //ball1.OnPositionChanged -= p4.MovePlayer;
            //ball1.OnPositionChanged += p5.MovePlayer;

            //ball1.SetPosition(10, 20);//When Position Change =>
            ////From Player (1 - Eslam) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Player (2 - Abdallah) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Player (3 - Ahmed) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Player (5 - Mohamed) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (10 , 20)

            #endregion

            #region When Registeration || Player With Ball Movement Fire Event that refer to MovePlayer().

            ////When Register Referee On Ball To Fire Event(That refer to moveReferee Function) When Ball Position Change
            //Ball ball1 = new Ball() { };
            //Console.WriteLine($"{ball1}\n");// Ball Position - (0 , 0)

            //Referee r1 = new Referee() { Id = 1, Name = "Eslam" };
            //Referee r2 = new Referee() { Id = 2, Name = "Abdallah" };
            //Referee r3 = new Referee() { Id = 3, Name = "Ahmed" };
            //Referee r4 = new Referee() { Id = 4, Name = "Osama" };
            //Referee r5 = new Referee() { Id = 5, Name = "Mohamed" };

            ////Registration
            //ball1.OnPositionChanged += r1.MoveReferee;
            //ball1.OnPositionChanged += r2.MoveReferee;
            //ball1.OnPositionChanged += r3.MoveReferee;
            //ball1.OnPositionChanged += r4.MoveReferee;


            //ball1.SetPosition(50, 60);//When Position Change =>
            ////From Referee (1 - Eslam) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Referee (2 - Abdallah) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Referee (3 - Ahmed) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            ////From Referee (4 - Osama) :: Ball Position Changed : (Ball Position - (50 , 60)) :: Delta X&Y => (-50 , -60)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (50 , 60)

            //ball1.SetPosition(80, 90);//When Position Change =>
            ////From Referee (1 - Eslam) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Referee (2 - Abdallah) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Referee (3 - Ahmed) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            ////From Referee (4 - Osama) :: Ball Position Changed : (Ball Position - (80 , 90)) :: Delta X&Y => (-30 , -30)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (80 , 90)

            //Console.WriteLine($"====== After Replacement p4 with p5 =========");
            //ball1.OnPositionChanged -= r4.MoveReferee;
            //ball1.OnPositionChanged += r5.MoveReferee;

            //ball1.SetPosition(10, 20);//When Position Change =>
            ////From Referee (1 - Eslam) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Referee (2 - Abdallah) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Referee (3 - Ahmed) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            ////From Referee (5 - Mohamed) :: Ball Position Changed : (Ball Position - (10 , 20)) :: Delta X&Y => (70 , 70)
            //Console.WriteLine($"{ball1}\n");// Ball Position - (10 , 20)

            #endregion

        }
    }
}
