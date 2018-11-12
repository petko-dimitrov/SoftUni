<?php /** @var \TaskManagement\DTO\UserDTO|null $data */?>

<h1>Login User</h1>
<?php foreach ($errors as $error): ?>
<p style="color: red"><?=$error?></p>
<?php endforeach;?>
<form method="post">
    <div>
        <label for="username">Username: </label>
        <input type="text" name="username" value="<?=$data != null ? $data->getUsername() : ""?>" minlength="4" maxlength="255">
    </div>
    <div>
        <label for="password">Password: </label>
        <input type="password" name="password" value="<?=$data != null ? $data->getPassword() : ""?>" minlength="6" maxlength="255">
    </div>
    <div>
        <input type="submit" name="login" value="Login!">
    </div>
</form>