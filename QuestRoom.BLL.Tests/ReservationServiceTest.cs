using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace QuestRoomBLL.Tests
{
    [TestFixture]
    public class ReservationServiceTest
    {
        private IReservationService reservationService;
        private Mock<IUnitOfWork> uow;
        private Mock<IRepository<Reserv>> reservRepository;

        static ReservationServiceTest()
        {
            try
            {
                BLL.Infrastructure.AutoMapperConfig.Initialize();
            }
            catch { }
        }

        [SetUp]
        public void Load()
        {
            uow = new Mock<IUnitOfWork>();
            reservRepository = new Mock<IRepository<Reserv>>();

            uow.Setup(x => x.Reserves).Returns(reservRepository.Object);

            reservationService = new ReservationService(uow.Object);
        }

        [Test]
        public void GetAll_TryToGetSomeList_ShouldRepositoryCallOnce_ShouldReturnNotNullList()
        {
            //arrange
            reservRepository.Setup(x => x.GetAll()).Returns(new List<Reserv>() { });

            //act & assert
            Assert.IsNotNull(reservationService.GetAll());
            reservRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Test]
        public void Add_TryToCreateNullValue_ShouldThrowException()
        {
            // act & assert
            Assert.Throws<ArgumentNullException>(() => reservationService.Add(null));
        }

        [Test]
        public void Add_TryToCreateElementWithNullQuest()
        {
            //arrange
            var reserv = new ReservDTO { Quest = null };
            uow.Setup(x => x.Quests.Get(It.IsAny<int>())).Returns<Quest>(null);

            //assert
            Assert.Throws<ArgumentNullException>(() => reservationService.Add(reserv));
        }

        [Test]
        public void Add_TryToAdd_ShouldRepositoryCreateOnce()
        {
            //arrange
            var reserv = new ReservDTO { Cost = It.IsAny<double>(),  Quest = new QuestDTO { Name = It.IsAny<string>() } };
            uow.Setup(x => x.Quests.Get(It.IsAny<int>())).Returns(new Quest { Name = It.IsAny<string>() });

            // act
            reservationService.Add(reserv);

            //assert
            reservRepository.Verify(x => x.Create(It.IsAny<Reserv>()), Times.Once);
        }

        [Test]
        public void Dispose()
        {
            Assert.DoesNotThrow(reservationService.Dispose);
        }
    }
}
