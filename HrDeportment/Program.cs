using HrDeportment;

PersonsList personsList = new PersonsList();

personsList.DeleteById(1);

personsList.GetAllActive().ForEach(person =>
{
    Console.WriteLine(person);
});