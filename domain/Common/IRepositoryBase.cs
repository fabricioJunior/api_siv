using System;
namespace domain.common
{
	public interface IRepositoryBase<E>
	{

		E GetE(int id);

		List<E> getWhere(); 
		
	}
}

