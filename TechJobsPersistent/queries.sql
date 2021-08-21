--Part 1
 select Id, Name, EmployerId from jobs
--Part 2
select Name from emloyers where (Location = "St. Louis City")
--Part 3
select Name,Description from skills INNER JOIN jobskills on skills.Id = jobskills.SkillId order by Name 
