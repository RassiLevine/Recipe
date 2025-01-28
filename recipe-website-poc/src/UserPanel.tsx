import { Link, useNavigate } from "react-router-dom";
import { getUserStore } from "@rassilevine/reactutils"

export default function UserPanel() {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const username = useUserStore((state => state.userName));
    const rolename = useUserStore((state => state.roleName));
    const isLoggedIn = useUserStore((state => state.isLoggedIn));
    const logout = useUserStore((state => state.logout));
    const nav = useNavigate();
    const handleLogout = () => {
        -
        logout(username);
        nav('/');
    }


    return (
        <div>
            {isLoggedIn ? (
                <div>
                    <p>Welcome {username}! {rolename}</p>
                    <button onClick={() => handleLogout()}>Logout</button>
                    {/* <button onClick={() => logout(username)}>Logout</button> */}
                </div>
            ) : (
                <>
                    <Link className="nav-link" to="/login">Login</Link>
                </>
            )}
        </div>
    )
}
