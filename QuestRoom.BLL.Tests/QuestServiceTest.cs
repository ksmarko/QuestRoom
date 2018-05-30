using AutoMapper;
using BLL.Interfaces;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomBLL.Tests
{
    [TestFixture]
    public class QuestServiceTest
    {
        private IQuestService questService;
        private Mock<IUnitOfWork> uow;
        private Mock<IRepository<Quest>> questRepository;

        static QuestServiceTest()
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
            questRepository = new Mock<IRepository<Quest>>();

            uow.Setup(x => x.Quests).Returns(questRepository.Object);

            questService = new QuestService(uow.Object);
        }

        [Test]
        public void GetAll_TryToGetSomeList_ShouldRepositoryCallOnce_ShouldReturnNotNullList()
        {
            //arrange
            questRepository.Setup(x => x.GetAll()).Returns(new List<Quest>() { });

            //act & assert
            Assert.IsNotNull(questService.GetAll());
            questRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Test]
        public void Dispose()
        {
            Assert.DoesNotThrow(questService.Dispose);
        }

        [Test]
        public void Find_TryToGetNullValue_ShouldThrowException()
        {
            //arrange
            questRepository.Setup(x => x.Get(It.IsAny<int>())).Returns<Quest>(null);

            // act & assert
            Assert.IsNull(questService.Find(It.IsAny<int>()));
        }

        [Test]
        public void Find_TryToGetValue_ShouldReturnSomeValue()
        {
            //arrange
            var lot = new Quest { Name = It.IsAny<string>(), Price = It.IsAny<double>(), Description = It.IsAny<string>() };
            uow.Setup(x => x.Quests.Get(It.IsAny<int>())).Returns(lot);

            // act & assert
            Assert.IsNotNull(questService.Find(It.IsAny<int>()));
        }

        [Test]
        public void Find()
        {
            // act & assert
            Assert.IsNotNull(questService.FilterResults(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()));
        }

        [Test]
        public void Find_TryToGetValueByPredicate_ShouldReturnSomeValue()
        {
            questRepository.Setup(s => s.Find(It.IsAny<Func<Quest, bool>>()))
            .Returns((Func<Quest, bool> expr) => new List<Quest>());

            questService.Find(x => x.Name == "name");

            uow.VerifyAll();
        }
    }    
}
