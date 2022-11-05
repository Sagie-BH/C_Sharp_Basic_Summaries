using System;

namespace BindingSource
{
    public enum Gender
    {
        Male,
        Female,
        UFO
    }
    class User
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string jobTitle;
        private int age;
        private Gender gender;
        private DateTime dateOfBirth;

        #endregion

        #region Properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public string FullName => $"{FirstName} {LastName}".Trim();
        public bool IsAgeValid => DateOfBirth.Date <= DateTime.Now.AddDays(-18);
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public bool IsInputValid =>
            !string.IsNullOrEmpty(FirstName) &&
            !string.IsNullOrEmpty(LastName) &&
            !string.IsNullOrEmpty(JobTitle);

        #endregion
        public User()
        {
            DateOfBirth = DateTime.Now;
        }
    }
}
