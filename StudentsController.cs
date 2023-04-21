using System.Collections.Generic;

namespace StudentsSample.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public Product Get()
        {
            // Get Data from Repository

            List<Student> response = new List<Student>();
		response.Add(new Stundent("Alice",20,["reading", "swimming", "coding"]));
		response.Add(new Stundent("Bob",22,["painting", "dancing", "singing"]));

		return response;
        }
    }

	public Class Student{
	public string Name {get;set;};
	public int age {get;set};
	public List<string> Hobbies{get;set;}
	}

}