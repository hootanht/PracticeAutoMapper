namespace PracticeAutoMapper.ViewModels
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }

        public string GetInformation()
        {
            string message = $" Name : {Name} , Family : {Family} , Age : {Age} , FullName : {FullName}";
            return message;
        }
    }
}
