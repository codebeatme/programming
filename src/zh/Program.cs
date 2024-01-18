AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
    Console.WriteLine($"你看，异常找上门了！{e}");

int dividend = 1;
int divisor = 0;
int result = dividend / divisor;