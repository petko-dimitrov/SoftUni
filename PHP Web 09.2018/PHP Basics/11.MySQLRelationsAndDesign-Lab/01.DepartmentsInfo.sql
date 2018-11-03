select department_id, count(*) as `Number of employees`
from employees 
group by department_id;