import { useState } from "react";

export default function Store({arrProducts}){
    const [products, setProducts] = useState(arrProducts);
    const [filterName, setFilterName] = useState('');


    return (<div>
        <div>
            <label>Name</label>
            <input onChange={(e)=> setFilterName(e.target.value)}/>
            <label></label>
            <input />
            <label></label>
            <input />
            <button>Filter</button>
        </div>
        </div>);
}