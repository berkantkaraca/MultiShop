using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoOperationManager : ICargoOperationService
    {
        private readonly ICargoOperationDal _cargoOperation;

        public CargoOperationManager(ICargoOperationDal cargoOperationDal)
        {
            _cargoOperation = cargoOperationDal;
        }

        public void TDelete(int id)
        {
            _cargoOperation.Delete(id);
        }

        public List<CargoOperation> TGetAll()
        {
            return _cargoOperation.GetAll();
        }

        public CargoOperation TGetById(int id)
        {
            return _cargoOperation.GetById(id);
        }

        public void TInsert(CargoOperation entity)
        {
            _cargoOperation.Insert(entity);
        }

        public void TUpdate(CargoOperation entity)
        {
            _cargoOperation.Update(entity);
        }
    }
}
