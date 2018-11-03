select e.first_name, e.last_name, t.name as town, a.address_text
from employees as e
join addresses as a on e.address_id = a.address_id
join towns as t on a.town_id = t.town_id
order by e.first_name, e.last_name
limit 5;