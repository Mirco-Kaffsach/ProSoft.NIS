using System.Diagnostics.CodeAnalysis;

namespace ProSoft.NIS.Contracts.DataModels;

/// <summary>
/// Class Port. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Port : IDisposable
{
	public int Id { get; set; }
	public int RackItemId { get; set; }
	public RackItem RackItem { get; set; }

	public int? CableAId { get; set; }
	public Cable CableA { get; set; }

	public int? CableBId { get; set; }
	public Cable CableB { get; set; }

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
	/// Finalizes an instance of the <see cref="Port"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	~Port()
	{
		this.Dispose(false);
	}

	#endregion
}
