using System.ComponentModel.DataAnnotations;

namespace AccommoLinkResidenceAssistance.Constants
{
	public enum Gender
	{
		[Display(Name = "Female")]
		Female,
		[Display(Name = "Male")]
		Male,
		[Display(Name = "Gender Fluid")]
		GenderFluid,
		[Display(Name = "Non-Confirming")]
		NonBinary
	}
	public enum Race
	{
		[Display(Name = "African")]
		African,
		[Display(Name = "Colored")]
		Colored,
		[Display(Name = "Indian")]
		Indian,
		[Display(Name = "White")]
		White,
		[Display(Name = "Other")]
		Other
	}
	public enum UserRole
	{
		[Display(Name = "Admin")]
		Admin,
		[Display(Name = "Student")]
		Student,
		[Display(Name = "University")]
		University,
		[Display(Name = "Landlord")]
		Landlord
	}
	public enum RegisterRole
	{
		[Display(Name = "Student")]
		Student = 1,
		[Display(Name = "University")]
		University,
		[Display(Name = "Landlord")]
		Landlord
	}
	public enum Citizenship
	{
		[Display(Name = "Citizenship by Birth")]
		Birth,
		[Display(Name = "Citizenship by Descent")]
		Descent,
		[Display(Name = "Citizenship by Naturalization")]
		Naturalization,
		[Display(Name = "Foreign National")]
		ForeignNational,
		Refugee
	}
	public enum MaritalStatus
	{
		Married,
		Divorced,
		Partnership,
		Separated,
		Single,
		Widowed
	}
	public enum Provinces
	{
		[Display(Name = "Eastern Cape")]
		EasternCape,
		[Display(Name = "Free State")]
		FreeState,
		Gauteng,
		[Display(Name = "Kwa-Zulu Natal")]
		KwaZuluNatal,
		Limpopo,
		Mpumalanga,
		[Display(Name = "North West")]
		NorthWest,
		[Display(Name = "Northern Cape")]
		NorthernCape,
		[Display(Name = "Western Cape")]
		WesternCape
	}

	public enum Titles
	{
		Mx, Mr, Mrs, Miss, Ms, Dr, Prof, Rabbi, Rev
	}

	public enum Catering
	{
		[Display(Name = "Self Catering")]SelfCatering,
		Catered,
		Optional
	}

	public enum RoomTypes
	{
		Single,
		[Display(Name ="Single Ensuite")]SingleEnsuite,
		Sharing,
		[Display(Name ="Sharing Ensuite")]SharingEnsuite,
	}

	public enum Status
	{
		Pending,
		Approved,
		Suspended,
		Blocked
	}
}
 