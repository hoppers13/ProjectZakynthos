using System;

namespace ProjectZakynthos.Persistence
{
	public interface IWishRepository
	{
		int Get(Guid id);
	}
}
