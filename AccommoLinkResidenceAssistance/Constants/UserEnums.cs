﻿using System.ComponentModel.DataAnnotations;

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
	//public enum HearFromUs 
	//{
	//	[Display(Name = "Social Media")]
	//	SocialMedia,
	//	Family,
	//	Friend,
	//	Doctor,
	//	Radio,
	//	Newspaper,
	//	School,
	//	[Display(Name = "Local Clinic")]
	//	LocalClinic,
	//	Other
	//}
	//public enum SessionPreference
	//{
	//	Online,
	//	[Display(Name = "Face to Face")]
	//	FaceToFace
	//}
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

	//public enum PractitionerType
	//{
	//	Counsellor, Nurse, Doctor
	//}

	//public enum CounsellorType
	//{
	//	[Display(Name = "Marriage and family counsellor")]
	//	FamilyCounsellor,
	//       [Display(Name = "Mental health counsellor")]
	//       MentalHealthCounsellor,
	//       [Display(Name = "General counsellor")]
	//       GeneralCounsellor,
	//	[Display(Name = "Trauma counsellor")]
	//	TraumaCounsellor
	//}

	//public enum VaccinableDiseases
	//{
	//	Chickenpox,
	//	Mumps,
	//	[Display(Name = "Hepatitis A")]
	//	HepatitisA,
	//	[Display(Name = "Hepatitis B")]
	//	HepatitisB,
	//	Measles,
	//	[Display(Name = "Human Papillomavirus (HPV)")]
	//	HPV,
	//	Smallpox,
	//	[Display(Name = "Tubercolosis (TB)")]
	//	TB,
	//	[Display(Name ="YellowFever")]
	//	YellowFever,
	//	Cholera,
	//	Rabies,
	//	[Display(Name = "Shingles (Herpes Zoster")]
	//	Herpes
	//}

	//public enum BookingReasons
	//{
	//	Termination, [Display(Name = "Preventative Contraceptives")] PreventativeContraceptives, [Display(Name = "Emergency Contraceptives")] EmergencyContraceptives,
	//}

	//public enum EmotionalChallenges
	//{
	//	Suicidal,
	//	Depression,
	//	Nervous,
	//	Apathy,
	//	[Display(Name ="Feelings of Hopelessness")] FeelingHopeless,
	//	[Display(Name ="Trouble Sleeping")] TroubleSleeping,
	//	[Display(Name ="Increased Cynicism or Pessimism")] MoreCynicalAndPessimistic,
	//	[Display(Name ="Sense of Dread")] SenseOfDread,
	//       [Display(Name ="Lack of Motivation")] LackUnmotivation,
	//	Irritability,
	//	[Display(Name ="Physical Fatigue")] PhysicalFatigue,
	//	Absentmindedness,
	//	[Display(Name ="Change in Appetite")] NoAppetite,
	//	[Display(Name ="Difficulty Concentrating")] CannotConcentrate,
	//	[Display(Name ="Irrational Angernger")] IrrationalAnger,
	//	[Display(Name ="Doctor/Nurse Referral")] DoctorReferral
	//   }

	//public enum Role
	//{
	//	[Display(Name ="Victim")] Victim,
	//       [Display(Name = "Community member")] CommunityMember,
	//       [Display(Name = "Family member")] familyMember,
	//        Other,
	//   }

	//public enum IdentityType
	//{
	//	Yes , No
	//}

	//   public enum IncidentType
	//{
	//       [Display(Name = "Physical Abuse")] physicalAbuse,
	//       [Display(Name = "Emotional Abuse")] EmotionalAbuse,
	//       Rape,
	//	Other
	//   }

	//public enum CommunicationType
	//{
	//	Phone,Email
	//}

	//public enum CounsellingBooking
	//{
	//	Yes,No
	//}
}
 