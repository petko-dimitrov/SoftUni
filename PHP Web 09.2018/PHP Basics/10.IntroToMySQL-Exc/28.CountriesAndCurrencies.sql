select country_name, country_code,
(case currency_code when 'EUR' THEN 'Euro' ELSE 'Not Euro' END) as currency
from countries
order by country_name;