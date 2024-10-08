﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Services;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentRepository;

namespace StudentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("All-Students")]
        public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllStudentsAsync();

            return Ok(students);
        }

        [HttpGet("Single-Student/{id}")]
        public async Task<ActionResult<Student>> GetSingleStudentAsync(int id)
        {
            var student = await _studentRepository.GetStudentByIdAsync(id);

            return Ok(student);
        }

        [HttpPost("Add-Student")]
        public async Task<ActionResult<Student>> AddNewStudentAsync(Student student)
        {
            var newstudent = await _studentRepository.AddStudentAsync(student);

            return Ok(newstudent);
        }

        [HttpGet("Delete-Student/{id}")]
        public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
        {
            var Deletestudent = await _studentRepository.DeleteStudentAsync(id);

            return Ok(Deletestudent);
        }
        public StudentController()
        {

        }

        [HttpGet("Update-Student")]
        public async Task<ActionResult<Student>> UpdateStudentAsync(Student student)
        {
            var updatestudent = await _studentRepository.UpdateStudentAsync(student);

            return Ok(updatestudent);
        }
    }
}
