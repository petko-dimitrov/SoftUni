SELECT e.employee_id, e.first_name, IF(DATE(pr.start_date) < '2005-01-01', pr.name, NULL) AS project_name
FROM employees e
JOIN employees_projects p 
ON e.employee_id = p.employee_id
JOIN projects pr ON p.project_id = pr.project_id 
WHERE p.employee_id = 24 
ORDER BY pr.name;