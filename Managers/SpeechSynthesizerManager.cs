using System;
using Accessors;

namespace Managers
{
	public class SpeechSynthesizerManager
	{
		public SpeechSynthesizerManager ()
		{
		}

		public void Speak(string SayThis)
		{
			new SpeechSynthesizerAccessors ().Speak (SayThis);
		}
	}
}

