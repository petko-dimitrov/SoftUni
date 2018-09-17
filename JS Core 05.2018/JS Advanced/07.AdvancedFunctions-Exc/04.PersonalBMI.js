function solve(name, age, weight, height) {
    let patient = {};
    patient['name'] = name;
    patient['personalInfo'] = {};
    patient['personalInfo']['age'] = age;
    patient['personalInfo']['weight'] = weight;
    patient['personalInfo']['height'] = height;
    patient['BMI'] = Math.round(weight / Math.pow(height/ 100, 2));
    let status = '';
    let bmi = patient['BMI'];

    if (bmi < 18.5) {
        status = 'underweight';
    } else if (bmi < 25) {
        status = 'normal';
    } else if (bmi < 30) {
        status = 'overweight';
    } else {
        status = 'obese';
    }

    patient['status'] = status;

    if (patient['status'] === 'obese') {
        patient['recommendation'] = 'admission required';
    }

    return patient;
}

solve('Peter', 29, 75, 182);