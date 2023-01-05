// See https://aka.ms/new-console-template for more information

using StartersApplication.Models;
using StartersApplication.DbContexts;


 DoctorApponitmentDBContext dbContext = new DoctorApponitmentDBContext();

ShowPatients();



//CRUD 

Console.WriteLine("Enter the Patient Details");
Patient patient = new Patient();
Console.WriteLine("Patient Name :");
patient.PatientName = Console.ReadLine();
Console.WriteLine("Patient Email :");
patient.Email = Console.ReadLine();
Console.WriteLine("Contact");
patient.Contact = long.Parse(Console.ReadLine());
Console.WriteLine("Patient History");
patient.PatientHistory = Console.ReadLine();

Console.WriteLine("-------");

dbContext.Patients.Add(patient);//build a SQL insert query 

dbContext.SaveChanges();//SQL query gets executed and saves the changes in the resp. table.


ShowPatients();


void ShowPatients()
{

    Console.WriteLine("Patient Details From Reddy's Hospital");

    List<Patient> patients = dbContext.Patients.ToList();

    foreach (Patient item in patients)
    {
        Console.WriteLine(item.PatientName + "    " + item.Contact + "     " + item.PatientHistory);
    }
}

