//using Xunit;
//using Moq;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using BookStore.User.Api.Controllers;
//using BookStore.User.Api.Logic.Query;
//using BookStore.User.Api.Domain.Model;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace BookStore.User.Api.Tests.Controllers
//{
//    public class UserControllerTests
//    {
//        private readonly Mock<IMediator> _mediatorMock;
//        private readonly UserController _controller;

//        public UserControllerTests()
//        {
//            _mediatorMock = new Mock<IMediator>();
//            _controller = new UserController(_mediatorMock.Object);
//        }

//        [Fact]
//        public async Task GetAllUsers_ReturnsOk_WithUsers()
//        {
//            // Arrange
//            var users = new List<UserResponse>
//            {
//                new UserResponse { Id = 1, Name = "Vaishakhi" }
//            };
//            _mediatorMock
//                .Setup(m => m.Send(It.IsAny<GetAllUsersQuery>(), It.IsAny<CancellationToken>()))
//                .ReturnsAsync(users);

//            // Act
//            var result = await _controller.GetAllUsers();

//            // Assert
//            var okResult = Assert.IsType<OkObjectResult>(result);
//            var response = Assert.IsType<Response<List<UserResponse>>>(okResult.Value);
//            Assert.True(response.Success);
//            Assert.Single(response.Data);
//            Assert.Equal("Vaishakhi", response.Data[0].Name);
//        }

//        [Fact]
//        public async Task GetAllUsers_ReturnsOk_NoUsersFound()
//        {
//            // Arrange
//            var users = new List<UserResponse>();
//            _mediatorMock
//                .Setup(m => m.Send(It.IsAny<GetAllUsersQuery>(), It.IsAny<CancellationToken>()))
//                .ReturnsAsync(users);

//            // Act
//            var result = await _controller.GetAllUsers();

//            // Assert
//            var okResult = Assert.IsType<OkObjectResult>(result);
//            var response = Assert.IsType<Response<List<UserResponse>>>(okResult.Value);
//            Assert.IsTrue(response.Success);
//            Assert.Empty(response.Data);
//            Assert.Equal("No data found", response.Message);
//        }
//    }
//}
