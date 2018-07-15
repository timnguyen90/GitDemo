public public class Student 
{
  	public int Id { get; set; }
  	public string FullName { get; set; }
  	
  	public Student () 
  	{
  	  
  	}
	//Fix issue
	public Student(int Id, string FullName){
		this.Id = ID;
		this.FullName = FullName;
	}
	//End Fix issue

}