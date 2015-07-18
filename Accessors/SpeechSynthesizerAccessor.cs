using System;
using System.Speech.Synthesis;
using Accessors;
using DataContracts;
using System.Collections.Generic;

namespace Accessors
{
	public class SpeechSynthesizerAccessors
	{
		SpeechSynthesizer synth;
		public SpeechSynthesizerAccessors ()
		{
			// Initialize a new instance of the SpeechSynthesizer.
			SpeechSynthesizer synth = new SpeechSynthesizer();

			// Configure the audio output. 
			synth.SetOutputToDefaultAudioDevice();

		}

		public void Speak(string SayThis)
		{
			// Speak a string.
			synth.SpeakAsync(SayThis);
		}
	}
}



