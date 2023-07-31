using System.Diagnostics.CodeAnalysis;

namespace ProSoft.NIS.Contracts.DataModels;

/// <summary>
/// Class Hallway. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Hallway : IDisposable
{
	public int Id { get; set; }
	public int FloorId { get; set; }
	public Floor Floor { get; set; }
	public List<Room> Rooms { get; set; }

	#region IDisposable Interface Implementation

	private bool disposed;

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	[ExcludeFromCodeCoverage]
	private void Dispose(bool disposing)
	{
		if (!this.disposed && disposing)
		{
			// Disposing Logic
		}

		this.disposed = true;
	}

	/// <summary>
	/// Finalizes an instance of the <see cref="Hallway"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	~Hallway()
	{
		this.Dispose(false);
	}

	#endregion
}
