using System;
using System.Collections.Generic;

namespace DataContracts
{
	public class ActionResult<TValue> 
	{
		public ActionResult ()
		{
			Success = false;
			mErrorMessages = new List<ErrorMessage> ();
			mInformationMessages = new List<InformationMessage> ();
		}

		public TValue ReturnObject { get; set; }

		public long PrimaryKey { get; set; }

		public bool Success { get; set; }

		private List<ErrorMessage> mErrorMessages = new List<ErrorMessage>();

		public List<ErrorMessage> ErrorMessages
		{
			get { return mErrorMessages; }
		}

		public void ReplaceErrorMessages(List<ErrorMessage> messages)
		{
			mErrorMessages = messages;
		}

		private List<InformationMessage> mInformationMessages = new List<InformationMessage>();

		public List<InformationMessage> InformationMessages
		{
			get { return mInformationMessages; }
		}

		public void ReplaceInformationMessages(List<InformationMessage> messages)
		{
			mInformationMessages = messages;
		}

	}




	public class ErrorMessage
	{
		public string FieldName { get; set; }

		public string Message { get; set; }
	}



	public class InformationMessage
	{
		public string FieldName { get; set; }

		public string Message { get; set; }
	}
}

