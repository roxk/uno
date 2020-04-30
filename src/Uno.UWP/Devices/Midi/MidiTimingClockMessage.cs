using System;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
	/// <summary>
	/// Represents a MIDI message that specifies a timing clock.
	/// </summary>
	public partial class MidiTimingClockMessage : IMidiMessage
	{
		/// <summary>
		/// Creates a new MidiTimingClockMessage object.
		/// </summary>
		public MidiTimingClockMessage()
		{
			RawData = new InMemoryBuffer(new byte[]
			{
				(byte)Type
			});
		}

		/// <summary>
		/// Gets the type of this MIDI message.
		/// </summary>
		public MidiMessageType Type => MidiMessageType.TimingClock;

		/// <summary>
		/// Gets the array of bytes associated with the MIDI message, including status byte.
		/// </summary>
		public IBuffer RawData { get; }

		/// <summary>
		/// Gets the duration from when the MidiInPort was created to the time the message was received.
		/// For messages being sent to a MidiOutPort, this value has no meaning.
		/// </summary>
		public TimeSpan Timestamp { get; }
	}
}
