using System.Diagnostics.CodeAnalysis;

namespace ProSoft.NIS.Contracts.DataModels;

/// <summary>
/// Class Floor. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Floor : IDisposable
{
	public int Id { get; set; }
	public int BuildingId { get; set; }
	public Building Building { get; set; }
	public List<Hallway> Hallways { get; set; }

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
	/// Finalizes an instance of the <see cref="Floor"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	~Floor()
	{
		this.Dispose(false);
	}

	#endregion
}
