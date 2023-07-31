using System.Diagnostics.CodeAnalysis;

namespace ProSoft.NIS.Contracts.DataModels;

/// <summary>
/// Class Switch. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="RackItem" />
/// <seealso cref="System.IDisposable" />
public sealed class Switch : RackItem
{
	public string Comment { get; set; }

	#region IDisposable Interface Implementation

	private bool disposed;

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	[ExcludeFromCodeCoverage]
	protected override void Dispose(bool disposing)
	{
		if (!this.disposed && disposing)
		{
			// Disposing Logic
		}

		this.disposed = true;
		base.Dispose(disposing);
	}

	/// <summary>
	/// Finalizes an instance of the <see cref="Switch"/> class.
	/// </summary>
	[ExcludeFromCodeCoverage]
	~Switch()
	{
		this.Dispose(false);
	}

	#endregion
}
