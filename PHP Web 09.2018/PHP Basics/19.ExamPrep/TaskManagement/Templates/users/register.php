<?php /** @var \TaskManagement\DTO\UserDTO|null $data */?>

<h1>User Registration</h1>
<?php foreach ($errors as $error): ?>
    <p style="color: red"><?=$error?></p>
<?php endforeach;?>
<form method="post">
    <div>
        <label for="username">Username:</label>
        <input type="text" name="username" value="<?=$data != null ? $data->getUsername() : ""?>" minlength="4" maxlength="255">
    </div>
    <div>
        <label for="password">Password:</label>
        <input type="password" name="password" value="<?=$data != null ? $data->getPassword() : ""?>" minlength="6" maxlength="255">
    </div>
    <div>
        <label for="confirm_password">Confirm password:</label>
        <input type="password" name="confirm_password" minlength="6" maxlength="255">
    </div>
    <div>
        <label for="first_name">First name:</label>
        <input type="text" name="firstName" value="<?=$data != null ? $data->getFirstName() : ""?>" minlength="3" maxlength="255">
    </div>
    <div>
        <label for="last_name">Last name:</label>
        <input type="text" name="lastName" value="<?=$data != null ? $data->getLastName() : ""?>" minlength="3" maxlength="255">
    </div>
    <div>
        <input type="submit" name="register" value="Register!">
    </div>
</form>