using HrDeportment;

PersonsList personsList = new PersonsList();

personsList.DeleteActiveById(1);
personsList.ChangePostActiveById(2, PostStorage.Posts[1]);
personsList.ChangeSalaryActiveById(2, 1000000S);


personsList.GetAllActive().ForEach(person =>
{
    Console.WriteLine(person);
});