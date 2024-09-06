namespace RecruitCatkudumusr.Models
{
	public class Candidate
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? StartDate { get; set; }
		public decimal TargetSalary { get; set; }
		public int Id { get; set; }
		public int? Age { get; set; }
		public int? CompanyID { get; set; }
		public int JobTitleID { get; set; }
		public int IndustryID { get; set; }

	}

	public class Company
	{
		public string Name { get; set; }
		public string PositionName { get; set; }
		public DateTime? StartDate { get; set; }
		public string Location { get; set; }
		public decimal MinimumSalary { get; set; }
		public decimal MaximumSalary { get; set; }
		public int Id { get; set; }
		public int CandidateID { get; set; }
		public List<Candidate> Candidates { get; set; }
		public int IndustryID { get; set; }
		public int JobTitleID { get; set; }

	}

	public class JobTitle
	{
		public string Title { get; set; }
		public decimal MinimumSalary { get; set; }
		public decimal MaximumSalary { get; set; }
		public int Id { get; set; }
		public List<Candidate> Candidates { get; set; }

	}

	public class Industry
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public List<Candidate> Candidates { get; set; }
		public List<Company> Companies { get; set; }

	}

}
