using FluentAssertions;
using NSubstitute;
using ProvaBlue.Business.Implementations;
using ProvaBlue.Models;
using ProvaBlue.Repository.Generic;
using System.Linq.Expressions;

namespace ProvaBlue.Tests.Business.Implementations {
    [TestFixture]
    public class ContatoBusniessImplementationsTests {

        [Test]
        public async Task CriarContato_WhenEverythingIsOk_ShouldReturnCreatedContact() {
            // arrange
            var repository = Substitute.For<IGenericRepository<ContatoModel>>();
            repository.Create(Arg.Is<ContatoModel>(o => !string.IsNullOrEmpty(o.Email))).Returns(new ContatoModel());
            var sut = new ContatoBusinessImplementations(repository);
            var contato = new ContatoModel() { Email = "email@teste.com" };

            // act
            var result = await sut.CriarContato(contato);

            // assert
            result.Should().NotBeNull();
        }

        [Test]
        public async Task CriarContato_WhenEmailAlreayExists_ShouldNotReturnCreatedContact() {
            // arrange
            var repository = Substitute.For<IGenericRepository<ContatoModel>>();
            repository.Create(Arg.Is<ContatoModel>(o => !string.IsNullOrEmpty(o.Email))).Returns(new ContatoModel());
            repository.FindByPredicate(Arg.Any<Expression<Func<ContatoModel, bool>>>()).Returns(new ContatoModel());
            var sut = new ContatoBusinessImplementations(repository);
            var contato = new ContatoModel() { };

            // act
            var result = await sut.CriarContato(contato);

            // assert
            result.Should().BeNull();
        }

    }
}
