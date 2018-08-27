namespace payslip
{
    public interface InputReaderInterface
    {
        string ReadFirstName();
        string ReadSurname();
        string ReadSalary();
        string ReadSuper();
        string ReadStartDate();
        string ReadEndDate();
        string Read();
    }
}