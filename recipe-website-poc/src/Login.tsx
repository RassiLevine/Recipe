import React, { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
// import { useUserStore } from "./UserStore/User"
import { getUserStore } from "@rassilevine/reactutils";
import { useNavigate } from "react-router-dom";

type LoginFormInputs = { username: string, password: string };
interface Props { frompath: string };
export default function Login({ frompath }: Props) {

    const { register, handleSubmit, formState: { errors } } = useForm<LoginFormInputs>();
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const login = useUserStore((state) => state.login);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);
    const [crashmsg, setCrashmsg] = useState("");
    const errormsg = useUserStore(state => state.errorMessage);
    const nav = useNavigate();

    useEffect(() => {
        if (isLoggedIn) {
            let pathval = !frompath || frompath == location.pathname ? "/" : frompath;
            nav(pathval);
        }
    }, [isLoggedIn, frompath, nav]);

    const onSubmit = async (data: LoginFormInputs) => {
        try {
            setCrashmsg("");
            await login(data.username, data.password);
        }
        catch (error: unknown) {
            if (error instanceof Error) {
                setCrashmsg(error.message);
                console.log(error.message);
            }
            else {
                setCrashmsg("error");
            }
        }


    }
    return (
        <>
            <h2 className="mb-4 text-center text-danger">{crashmsg || errormsg || null}</h2>
            <div className="d-flex justify-content-center">
                <div className="col-6">
                    <form onSubmit={handleSubmit(onSubmit)}>
                        <label>Username</label>
                        <input type="text" {...register('username', { required: 'Username is required' })} />
                        {errors.username && <span>{errors.username.message}</span>}
                        <br />
                        <label>Password</label>
                        <input type="password"
                            {...register('password', { required: 'Password is required' })} />
                        {errors.password && <span>{errors.password.message}</span>}
                        <br />
                        <button type="submit">Login</button>
                    </form>
                </div>
            </div>

        </>
    )
}
